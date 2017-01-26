using System;
using System.Data.Entity;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebPanel.Services;
using WebPanel.Model;

namespace WebPanel.Controls
{
    public partial class TaskListControl : UserControl
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BindGrid();
        }

        private void BindGrid()
        {
            var items = ApplicationContext.Instance.TaskService.GetAllItems();

            if (items.Any())
            {
                TaskPanel.Visible = true;
                ErrorPanel.Visible = false;

                DataGrid.DataSource = items;
                DataGrid.DataBind();

                foreach (DataGridItem item in DataGrid.Items)
                {
                    var button = item.Cells[3];
                    button.Visible = !((CheckBox)item.Cells[2].FindControl("CheckBox")).Checked;
                }
            }
            else
            {
                TaskPanel.Visible = false;
                ErrorPanel.Visible = true;
            }
        }

        protected void DataGrid_OnItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "DoneClicked":
                    {
                        var idField = e.Item.Controls[2].FindControl("ID") as HiddenField;
                        if (idField != null)
                        {
                            var id = int.Parse(idField.Value);
                            var task = ApplicationContext.Instance.TaskService.GetItemById(id);

                            if (task != null)
                            {
                                task.IsCompleted = true;
                                ApplicationContext.Instance.TaskService.UpdateItem(task);
                            }
                        }
                        break;
                    }
            }
            BindGrid();
        }

        protected void AddButton_OnClick(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/NewTask.aspx");
        }

        protected void RemoveAllButton_OnClick(object sender, EventArgs e)
        {
            ApplicationContext.Instance.TaskService.DeleteAllItems();
            BindGrid();
        }
    }
}