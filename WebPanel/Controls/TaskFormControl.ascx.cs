﻿using System;
using System.Web.UI;
using WebPanel.Services;
using WebPanel.Model;

namespace WebPanel.Controls
{
    public partial class TaskFormControl : UserControl
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
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
                TaskPanel.Visible = true;
                ErrorPanel.Visible = false;

                Task.Text = task.Name;
                Repeats.Text = task.Repeats;
                Completed.Checked = task.IsCompleted;
            }
            else
            {
                TaskPanel.Visible = false;
                ErrorPanel.Visible = true;
            }

        }
    }
}