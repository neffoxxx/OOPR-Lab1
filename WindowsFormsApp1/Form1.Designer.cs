namespace Labor1
{
    partial class Form1
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTravelTime = new System.Windows.Forms.TextBox();
            this.tbDepartureTime = new System.Windows.Forms.TextBox();
            this.tbDestinationStation = new System.Windows.Forms.TextBox();
            this.tbTrainNumber = new System.Windows.Forms.TextBox();
            this.lvTrains = new System.Windows.Forms.ListView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnAddTrain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(44, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Час в дорозі:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(44, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Час відправлення:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Станція призначення:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Номер поїзда:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Заповніть інформацію про поїзди:";
            // 
            // tbTravelTime
            // 
            this.tbTravelTime.Location = new System.Drawing.Point(267, 192);
            this.tbTravelTime.Name = "tbTravelTime";
            this.tbTravelTime.Size = new System.Drawing.Size(100, 22);
            this.tbTravelTime.TabIndex = 22;
            // 
            // tbDepartureTime
            // 
            this.tbDepartureTime.Location = new System.Drawing.Point(267, 166);
            this.tbDepartureTime.Name = "tbDepartureTime";
            this.tbDepartureTime.Size = new System.Drawing.Size(100, 22);
            this.tbDepartureTime.TabIndex = 21;
            // 
            // tbDestinationStation
            // 
            this.tbDestinationStation.Location = new System.Drawing.Point(267, 136);
            this.tbDestinationStation.Name = "tbDestinationStation";
            this.tbDestinationStation.Size = new System.Drawing.Size(100, 22);
            this.tbDestinationStation.TabIndex = 20;
            // 
            // tbTrainNumber
            // 
            this.tbTrainNumber.Location = new System.Drawing.Point(267, 108);
            this.tbTrainNumber.Name = "tbTrainNumber";
            this.tbTrainNumber.Size = new System.Drawing.Size(100, 22);
            this.tbTrainNumber.TabIndex = 19;
            // 
            // lvTrains
            // 
            this.lvTrains.HideSelection = false;
            this.lvTrains.HoverSelection = true;
            this.lvTrains.Location = new System.Drawing.Point(432, 108);
            this.lvTrains.Name = "lvTrains";
            this.lvTrains.Size = new System.Drawing.Size(315, 97);
            this.lvTrains.TabIndex = 18;
            this.lvTrains.UseCompatibleStateImageBehavior = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(664, 230);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 44);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Вивести список";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(524, 230);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(134, 44);
            this.btnLoadFromFile.TabIndex = 16;
            this.btnLoadFromFile.Text = "Завантажити з файлу";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(432, 230);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(86, 44);
            this.btnSaveToFile.TabIndex = 15;
            this.btnSaveToFile.Text = "Зберегти до файлу";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnAddTrain
            // 
            this.btnAddTrain.Location = new System.Drawing.Point(267, 230);
            this.btnAddTrain.Name = "btnAddTrain";
            this.btnAddTrain.Size = new System.Drawing.Size(100, 44);
            this.btnAddTrain.TabIndex = 14;
            this.btnAddTrain.Text = "Додати інформацію";
            this.btnAddTrain.UseVisualStyleBackColor = true;
            this.btnAddTrain.Click += new System.EventHandler(this.btnAddTrain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTravelTime);
            this.Controls.Add(this.tbDepartureTime);
            this.Controls.Add(this.tbDestinationStation);
            this.Controls.Add(this.tbTrainNumber);
            this.Controls.Add(this.lvTrains);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnAddTrain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTravelTime;
        private System.Windows.Forms.TextBox tbDepartureTime;
        private System.Windows.Forms.TextBox tbDestinationStation;
        private System.Windows.Forms.TextBox tbTrainNumber;
        private System.Windows.Forms.ListView lvTrains;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnAddTrain;
    }
}

