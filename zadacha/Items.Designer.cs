
namespace metodichka
{
    partial class Items
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
            this.list = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quatity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Refresher = new System.Windows.Forms.Button();
            this.add_item = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.name,
            this.quatity,
            this.date,
            this.Autor});
            this.list.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list.GridLines = true;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(558, 241);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "№ п/п";
            // 
            // name
            // 
            this.name.Text = "Заголовок";
            this.name.Width = 115;
            // 
            // quatity
            // 
            this.quatity.Text = "Содержание";
            this.quatity.Width = 114;
            // 
            // date
            // 
            this.date.Text = "Дата публикации";
            this.date.Width = 156;
            // 
            // Refresher
            // 
            this.Refresher.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Refresher.Location = new System.Drawing.Point(576, 12);
            this.Refresher.Name = "Refresher";
            this.Refresher.Size = new System.Drawing.Size(126, 53);
            this.Refresher.TabIndex = 1;
            this.Refresher.Text = "Обновить";
            this.Refresher.UseVisualStyleBackColor = true;
            this.Refresher.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // add_item
            // 
            this.add_item.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_item.Location = new System.Drawing.Point(576, 71);
            this.add_item.Name = "add_item";
            this.add_item.Size = new System.Drawing.Size(126, 88);
            this.add_item.TabIndex = 2;
            this.add_item.Text = "Добавить статью";
            this.add_item.UseVisualStyleBackColor = true;
            this.add_item.Click += new System.EventHandler(this.Add_item_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(576, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 87);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить пользователя";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Autor
            // 
            this.Autor.Text = "Автор статьи";
            this.Autor.Width = 108;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_item);
            this.Controls.Add(this.Refresher);
            this.Controls.Add(this.list);
            this.Name = "Items";
            this.Text = "Items";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader quatity;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button Refresher;
        private System.Windows.Forms.Button add_item;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Autor;
    }

}