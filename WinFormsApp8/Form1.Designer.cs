namespace VstrechiProgram
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Элементы управления
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelate;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.ListBox listBoxMeetings;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label labelResultTitle;
        private System.Windows.Forms.Label labelResult;

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
            labelTitle = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            labelTime = new Label();
            textBoxTime = new TextBox();
            buttonAdd = new Button();
            buttonDelate = new Button();
            labelList = new Label();
            listBoxMeetings = new ListBox();
            buttonFind = new Button();
            labelResultTitle = new Label();
            labelResult = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            labelTitle.Location = new Point(150, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ПЛАНИРОВЩИК ВСТРЕЧ";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.Location = new Point(30, 70);
            labelName.Name = "labelName";
            labelName.Size = new Size(120, 25);
            labelName.TabIndex = 1;
            labelName.Text = "Название встречи:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Arial", 10F);
            textBoxName.Location = new Point(160, 70);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 23);
            textBoxName.TabIndex = 2;
            // 
            // labelTime
            // 
            labelTime.Location = new Point(30, 105);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(120, 25);
            labelTime.TabIndex = 3;
            labelTime.Text = "Время (0.0-23.59):";
            // 
            // textBoxTime
            // 
            textBoxTime.Font = new Font("Arial", 10F);
            textBoxTime.Location = new Point(160, 105);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(100, 23);
            textBoxTime.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonAdd.Location = new Point(280, 100);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 35);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Добавить встречу";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelate
            // 
            buttonDelate.FlatStyle = FlatStyle.Flat;
            buttonDelate.Font = new Font("Arial", 9F);
            buttonDelate.Location = new Point(440, 100);
            buttonDelate.Name = "buttonDelate";
            buttonDelate.Size = new Size(80, 35);
            buttonDelate.TabIndex = 6;
            buttonDelate.Text = " Удалить";
            buttonDelate.UseVisualStyleBackColor = false;
            buttonDelate.Click += buttonDelate_Click;
            // 
            // labelList
            // 
            labelList.Font = new Font("Arial", 10F, FontStyle.Bold);
            labelList.Location = new Point(30, 150);
            labelList.Name = "labelList";
            labelList.Size = new Size(200, 20);
            labelList.TabIndex = 7;
            labelList.Text = "СПИСОК ВСЕХ ВСТРЕЧ:";
            // 
            // listBoxMeetings
            // 
            listBoxMeetings.BorderStyle = BorderStyle.FixedSingle;
            listBoxMeetings.Font = new Font("Courier New", 10F);
            listBoxMeetings.Location = new Point(30, 173);
            listBoxMeetings.Name = "listBoxMeetings";
            listBoxMeetings.Size = new Size(500, 146);
            listBoxMeetings.TabIndex = 8;
            // 
            // buttonFind
            // 
            buttonFind.FlatStyle = FlatStyle.Flat;
            buttonFind.Font = new Font("Arial", 11F, FontStyle.Bold);
            buttonFind.Location = new Point(30, 340);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(500, 40);
            buttonFind.TabIndex = 9;
            buttonFind.Text = "НАЙТИ САМУЮ ПОЗДНЮЮ ВСТРЕЧУ ДО ПОЛУДНЯ";
            buttonFind.UseVisualStyleBackColor = false;
            buttonFind.Click += buttonFind_Click;
            // 
            // labelResultTitle
            // 
            labelResultTitle.Font = new Font("Arial", 10F, FontStyle.Bold);
            labelResultTitle.Location = new Point(30, 390);
            labelResultTitle.Name = "labelResultTitle";
            labelResultTitle.Size = new Size(150, 20);
            labelResultTitle.TabIndex = 10;
            labelResultTitle.Text = "РЕЗУЛЬТАТ ПОИСКА:";
            // 
            // labelResult
            // 
            labelResult.BorderStyle = BorderStyle.FixedSingle;
            labelResult.Font = new Font("Arial", 12F, FontStyle.Bold);
            labelResult.Location = new Point(30, 415);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(500, 40);
            labelResult.TabIndex = 11;
            labelResult.Text = "Нажмите кнопку поиска";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            ClientSize = new Size(580, 480);
            Controls.Add(labelTitle);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelTime);
            Controls.Add(textBoxTime);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelate);
            Controls.Add(labelList);
            Controls.Add(listBoxMeetings);
            Controls.Add(buttonFind);
            Controls.Add(labelResultTitle);
            Controls.Add(labelResult);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Планировщик встреч";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}