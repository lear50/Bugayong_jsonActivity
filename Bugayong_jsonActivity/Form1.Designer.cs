namespace Bugayong_jsonActivity
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewShoppingList = new System.Windows.Forms.Button();
            this.btnAddGroceries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewShoppingList
            // 
            this.btnViewShoppingList.Location = new System.Drawing.Point(50, 50);
            this.btnViewShoppingList.Name = "btnViewShoppingList";
            this.btnViewShoppingList.Size = new System.Drawing.Size(150, 50);
            this.btnViewShoppingList.TabIndex = 0;
            this.btnViewShoppingList.Text = "View Shopping List";
            this.btnViewShoppingList.UseVisualStyleBackColor = true;
            this.btnViewShoppingList.Click += new System.EventHandler(this.btnViewShoppingList_Click);
            // 
            // btnAddGroceries
            // 
            this.btnAddGroceries.Location = new System.Drawing.Point(50, 120);
            this.btnAddGroceries.Name = "btnAddGroceries";
            this.btnAddGroceries.Size = new System.Drawing.Size(150, 50);
            this.btnAddGroceries.TabIndex = 1;
            this.btnAddGroceries.Text = "Add Groceries";
            this.btnAddGroceries.UseVisualStyleBackColor = true;
            this.btnAddGroceries.Click += new System.EventHandler(this.btnAddGroceries_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 220);
            this.Controls.Add(this.btnAddGroceries);
            this.Controls.Add(this.btnViewShoppingList);
            this.Name = "Form1";
            this.Text = "Grocery List Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewShoppingList;
        private System.Windows.Forms.Button btnAddGroceries;
    }
}