namespace DrugAndDrop2
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonSourceDrag1 = new System.Windows.Forms.Button();
            this.textBoxTargetDrop = new System.Windows.Forms.TextBox();
            this.buttonSourceDrag2 = new System.Windows.Forms.Button();
            this.pictureBoxSurceDrag = new System.Windows.Forms.PictureBox();
            this.pictureBoxSourceDrag1 = new System.Windows.Forms.PictureBox();
            this.panelTargetDrag = new System.Windows.Forms.Panel();
            this.listBoxColors = new System.Windows.Forms.ListBox();
            this.listBoxFruits = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSurceDrag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSourceDrag1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSourceDrag1
            // 
            this.buttonSourceDrag1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSourceDrag1.Location = new System.Drawing.Point(12, 12);
            this.buttonSourceDrag1.Name = "buttonSourceDrag1";
            this.buttonSourceDrag1.Size = new System.Drawing.Size(221, 78);
            this.buttonSourceDrag1.TabIndex = 0;
            this.buttonSourceDrag1.Text = "Перетащи меня";
            this.buttonSourceDrag1.UseVisualStyleBackColor = true;
            this.buttonSourceDrag1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSourceDrag_MouseDown);
            // 
            // textBoxTargetDrop
            // 
            this.textBoxTargetDrop.AllowDrop = true;
            this.textBoxTargetDrop.Location = new System.Drawing.Point(510, 21);
            this.textBoxTargetDrop.Multiline = true;
            this.textBoxTargetDrop.Name = "textBoxTargetDrop";
            this.textBoxTargetDrop.Size = new System.Drawing.Size(206, 48);
            this.textBoxTargetDrop.TabIndex = 1;
            this.textBoxTargetDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxTargetDrop_DragDrop);
            this.textBoxTargetDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxTargetDrop_DragEnter);
            // 
            // buttonSourceDrag2
            // 
            this.buttonSourceDrag2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSourceDrag2.Location = new System.Drawing.Point(12, 97);
            this.buttonSourceDrag2.Name = "buttonSourceDrag2";
            this.buttonSourceDrag2.Size = new System.Drawing.Size(221, 78);
            this.buttonSourceDrag2.TabIndex = 2;
            this.buttonSourceDrag2.Text = "Нажми на меня";
            this.buttonSourceDrag2.UseVisualStyleBackColor = true;
            this.buttonSourceDrag2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSecond_MouseDown);
            // 
            // pictureBoxSurceDrag
            // 
            this.pictureBoxSurceDrag.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSurceDrag.Image")));
            this.pictureBoxSurceDrag.Location = new System.Drawing.Point(12, 241);
            this.pictureBoxSurceDrag.Name = "pictureBoxSurceDrag";
            this.pictureBoxSurceDrag.Size = new System.Drawing.Size(218, 169);
            this.pictureBoxSurceDrag.TabIndex = 3;
            this.pictureBoxSurceDrag.TabStop = false;
            this.pictureBoxSurceDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSurceDrag_MouseDown);
            // 
            // pictureBoxSourceDrag1
            // 
            this.pictureBoxSourceDrag1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSourceDrag1.Image")));
            this.pictureBoxSourceDrag1.Location = new System.Drawing.Point(236, 241);
            this.pictureBoxSourceDrag1.Name = "pictureBoxSourceDrag1";
            this.pictureBoxSourceDrag1.Size = new System.Drawing.Size(173, 169);
            this.pictureBoxSourceDrag1.TabIndex = 4;
            this.pictureBoxSourceDrag1.TabStop = false;
            this.pictureBoxSourceDrag1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSurceDrag_MouseDown);
            // 
            // panelTargetDrag
            // 
            this.panelTargetDrag.AllowDrop = true;
            this.panelTargetDrag.BackColor = System.Drawing.Color.Blue;
            this.panelTargetDrag.Location = new System.Drawing.Point(415, 75);
            this.panelTargetDrag.Name = "panelTargetDrag";
            this.panelTargetDrag.Size = new System.Drawing.Size(373, 287);
            this.panelTargetDrag.TabIndex = 5;
            this.panelTargetDrag.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTargetDrag_DragDrop);
            this.panelTargetDrag.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTargetDrag_DragEnter);
            // 
            // listBoxColors
            // 
            this.listBoxColors.AllowDrop = true;
            this.listBoxColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxColors.FormattingEnabled = true;
            this.listBoxColors.ItemHeight = 31;
            this.listBoxColors.Items.AddRange(new object[] {
            "Красный",
            "Синий ",
            "Зелёный ",
            "Оранж"});
            this.listBoxColors.Location = new System.Drawing.Point(12, 421);
            this.listBoxColors.Name = "listBoxColors";
            this.listBoxColors.Size = new System.Drawing.Size(267, 252);
            this.listBoxColors.TabIndex = 6;
            this.listBoxColors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxColors_MouseDown);
            // 
            // listBoxFruits
            // 
            this.listBoxFruits.AllowDrop = true;
            this.listBoxFruits.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFruits.FormattingEnabled = true;
            this.listBoxFruits.ItemHeight = 31;
            this.listBoxFruits.Items.AddRange(new object[] {
            "яблоко",
            "слива",
            "киви",
            "апельсин"});
            this.listBoxFruits.Location = new System.Drawing.Point(449, 421);
            this.listBoxFruits.Name = "listBoxFruits";
            this.listBoxFruits.Size = new System.Drawing.Size(267, 252);
            this.listBoxFruits.TabIndex = 7;
            this.listBoxFruits.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxFruits_DragDrop);
            this.listBoxFruits.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxFruits_DragEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 674);
            this.Controls.Add(this.listBoxFruits);
            this.Controls.Add(this.listBoxColors);
            this.Controls.Add(this.panelTargetDrag);
            this.Controls.Add(this.pictureBoxSourceDrag1);
            this.Controls.Add(this.pictureBoxSurceDrag);
            this.Controls.Add(this.buttonSourceDrag2);
            this.Controls.Add(this.textBoxTargetDrop);
            this.Controls.Add(this.buttonSourceDrag1);
            this.Name = "FormMain";
            this.Text = "Встроенный инструмент для перетаскивания объектов";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSurceDrag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSourceDrag1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSourceDrag1;
        private System.Windows.Forms.TextBox textBoxTargetDrop;
        private System.Windows.Forms.Button buttonSourceDrag2;
        private System.Windows.Forms.PictureBox pictureBoxSurceDrag;
        private System.Windows.Forms.PictureBox pictureBoxSourceDrag1;
        private System.Windows.Forms.Panel panelTargetDrag;
        private System.Windows.Forms.ListBox listBoxColors;
        private System.Windows.Forms.ListBox listBoxFruits;
    }
}

