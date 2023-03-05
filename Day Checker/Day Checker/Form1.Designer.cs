
namespace Day_Checker
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.label_from = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.label_dayCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker_from
            // 
            resources.ApplyResources(this.dateTimePicker_from, "dateTimePicker_from");
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.ValueChanged += new System.EventHandler(this.dateTimePicker_from_ValueChanged);
            // 
            // dateTimePicker_to
            // 
            resources.ApplyResources(this.dateTimePicker_to, "dateTimePicker_to");
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.ValueChanged += new System.EventHandler(this.dateTimePicker_to_ValueChanged);
            // 
            // label_from
            // 
            resources.ApplyResources(this.label_from, "label_from");
            this.label_from.Name = "label_from";
            // 
            // label_to
            // 
            resources.ApplyResources(this.label_to, "label_to");
            this.label_to.Name = "label_to";
            // 
            // label_dayCount
            // 
            resources.ApplyResources(this.label_dayCount, "label_dayCount");
            this.label_dayCount.Name = "label_dayCount";
            // 
            // Form_Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_dayCount);
            this.Controls.Add(this.label_to);
            this.Controls.Add(this.label_from);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.dateTimePicker_from);
            this.Name = "Form_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_dayCount;
    }
}

