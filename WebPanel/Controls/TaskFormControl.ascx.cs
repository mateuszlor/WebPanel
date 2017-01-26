using System;
using System.Web.UI;
using WebPanel.Services;
using WebPanel.Model;

namespace WebPanel.Controls
{
    public partial class TaskFormControl : UserControl
    {
        public FormMode Mode { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var modeParam = Page.Request.Params["Mode"];
            Mode = string.IsNullOrEmpty(modeParam)
                ? FormMode.New
                : (FormMode)Enum.Parse(typeof(FormMode), modeParam, true);

            switch (Mode)
            {
                case FormMode.Preview:
                    {
                        long taskId;
                        Task task = null;

                        var isValid = long.TryParse(Page.Request.Params["id"], out taskId);

                        if (isValid)
                        {
                            task = ApplicationContext.Instance.TaskService.GetItemById(taskId);

                            if (task == null)
                            {
                                isValid = false;
                            }
                        }

                        if (isValid)
                        {
                            TaskPanelPreview.Visible = true;
                            TaskPanelNew.Visible = false;
                            ErrorPanel.Visible = false;

                            Task.Text = task.Name;
                            Repeats.Text = task.Repeats;
                            Completed.Checked = task.IsCompleted;
                        }
                        else
                        {
                            TaskPanelPreview.Visible = false;
                            TaskPanelNew.Visible = false;
                            ErrorPanel.Visible = true;
                        }
                        break;
                    }
                case FormMode.New:
                    {
                        TaskPanelPreview.Visible = false;
                        TaskPanelNew.Visible = true;
                        ErrorPanel.Visible = false;
                        break;
                    }
            }
        }

        protected void AddButton_OnClick(object sender, EventArgs e)
        {
            var task = new Task
            {
                Name = NewName.Text,
                Repeats = NewRepeats.Text
            };
            ApplicationContext.Instance.TaskService.CreateNew(task);
            Page.Response.Redirect("~/");
        }
    }

    public enum FormMode
    {
        New,
        Preview
    }
}