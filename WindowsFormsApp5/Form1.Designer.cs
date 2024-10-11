namespace WindowsFormsApp5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button buttonEraser; // Добавлена кнопка стерки

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonColor = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.buttonEraser = new System.Windows.Forms.Button(); // Инициализация кнопки стерки
            this.SuspendLayout();

            // 
            // buttonLine
            // 
            this.buttonLine.BackColor = System.Drawing.Color.LightBlue;
            this.buttonLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLine.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonLine.Location = new System.Drawing.Point(12, 12);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(120, 40);
            this.buttonLine.TabIndex = 0;
            this.buttonLine.Text = "Линия"; // Изменено на русский
            this.buttonLine.UseVisualStyleBackColor = false;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);

            // 
            // buttonCircle
            // 
            this.buttonCircle.BackColor = System.Drawing.Color.LightGreen;
            this.buttonCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCircle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonCircle.Location = new System.Drawing.Point(138, 12);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(120, 40);
            this.buttonCircle.TabIndex = 1;
            this.buttonCircle.Text = "Круг"; // Изменено на русский
            this.buttonCircle.UseVisualStyleBackColor = false;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);

            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackColor = System.Drawing.Color.LightCoral;
            this.buttonRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRectangle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonRectangle.Location = new System.Drawing.Point(264, 12);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(120, 40);
            this.buttonRectangle.TabIndex = 2;
            this.buttonRectangle.Text = "Прямоугольник"; // Изменено на русский
            this.buttonRectangle.UseVisualStyleBackColor = false;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);

            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.White;
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonColor.Location = new System.Drawing.Point(390, 12);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(120, 40);
            this.buttonColor.TabIndex = 3;
            this.buttonColor.Text = "Цвет"; // Изменено на русский
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);

            // 
            // panelColor
            // 
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Location = new System.Drawing.Point(516, 12);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(50, 40);
            this.panelColor.TabIndex = 4;

            // 
            // buttonEraser
            // 
            this.buttonEraser.BackColor = System.Drawing.Color.LightPink;
            this.buttonEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEraser.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonEraser.Location = new System.Drawing.Point(572, 12); // Позиция кнопки
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(120, 40);
            this.buttonEraser.TabIndex = 5;
            this.buttonEraser.Text = "Стерка"; // Текст кнопки на русском
            this.buttonEraser.UseVisualStyleBackColor = false;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click); // Обработчик события

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonRectangle);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonEraser); // Добавляем кнопку стерки на форму
            this.Name = "Form1";
            this.Text = "Приложение для Рисования"; // Изменено на русский
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
        }
    }
}
