
namespace ProjectForms
{
    partial class ConnectForm
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
            this.tabControlOverview = new System.Windows.Forms.TabControl();
            this.tabPageConnect = new System.Windows.Forms.TabPage();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxAddressServer = new System.Windows.Forms.TextBox();
            this.labelStrConnect = new System.Windows.Forms.Label();
            this.tabPageGetData = new System.Windows.Forms.TabPage();
            this.buttonProcessCube = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCubes = new System.Windows.Forms.Label();
            this.labelDimensions = new System.Windows.Forms.Label();
            this.comboBoxCubes = new System.Windows.Forms.ComboBox();
            this.comboBoxDimensions = new System.Windows.Forms.ComboBox();
            this.buttonProcessDim = new System.Windows.Forms.Button();
            this.labelDateLastProcess = new System.Windows.Forms.Label();
            this.tabControlOverview.SuspendLayout();
            this.tabPageConnect.SuspendLayout();
            this.tabPageGetData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOverview
            // 
            this.tabControlOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlOverview.Controls.Add(this.tabPageConnect);
            this.tabControlOverview.Controls.Add(this.tabPageGetData);
            this.tabControlOverview.Location = new System.Drawing.Point(12, 12);
            this.tabControlOverview.Name = "tabControlOverview";
            this.tabControlOverview.SelectedIndex = 0;
            this.tabControlOverview.Size = new System.Drawing.Size(764, 362);
            this.tabControlOverview.TabIndex = 0;
            // 
            // tabPageConnect
            // 
            this.tabPageConnect.Controls.Add(this.buttonConnect);
            this.tabPageConnect.Controls.Add(this.textBoxAddressServer);
            this.tabPageConnect.Controls.Add(this.labelStrConnect);
            this.tabPageConnect.Location = new System.Drawing.Point(4, 25);
            this.tabPageConnect.Name = "tabPageConnect";
            this.tabPageConnect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnect.Size = new System.Drawing.Size(756, 419);
            this.tabPageConnect.TabIndex = 0;
            this.tabPageConnect.Text = "Подключение";
            this.tabPageConnect.UseVisualStyleBackColor = true;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(241, 274);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(300, 39);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxAddressServer
            // 
            this.textBoxAddressServer.Location = new System.Drawing.Point(18, 43);
            this.textBoxAddressServer.Name = "textBoxAddressServer";
            this.textBoxAddressServer.Size = new System.Drawing.Size(720, 22);
            this.textBoxAddressServer.TabIndex = 1;
            this.textBoxAddressServer.Text = "DESKTOP-9272AGI";
            // 
            // labelStrConnect
            // 
            this.labelStrConnect.AutoSize = true;
            this.labelStrConnect.Location = new System.Drawing.Point(15, 14);
            this.labelStrConnect.Name = "labelStrConnect";
            this.labelStrConnect.Size = new System.Drawing.Size(168, 17);
            this.labelStrConnect.TabIndex = 0;
            this.labelStrConnect.Text = "Введите адрес сервера:";
            // 
            // tabPageGetData
            // 
            this.tabPageGetData.Controls.Add(this.buttonProcessCube);
            this.tabPageGetData.Controls.Add(this.labelDate);
            this.tabPageGetData.Controls.Add(this.labelCubes);
            this.tabPageGetData.Controls.Add(this.labelDimensions);
            this.tabPageGetData.Controls.Add(this.comboBoxCubes);
            this.tabPageGetData.Controls.Add(this.comboBoxDimensions);
            this.tabPageGetData.Controls.Add(this.buttonProcessDim);
            this.tabPageGetData.Controls.Add(this.labelDateLastProcess);
            this.tabPageGetData.Location = new System.Drawing.Point(4, 25);
            this.tabPageGetData.Name = "tabPageGetData";
            this.tabPageGetData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGetData.Size = new System.Drawing.Size(756, 333);
            this.tabPageGetData.TabIndex = 1;
            this.tabPageGetData.Text = "Структура базы";
            this.tabPageGetData.UseVisualStyleBackColor = true;
            // 
            // buttonProcessCube
            // 
            this.buttonProcessCube.Location = new System.Drawing.Point(430, 259);
            this.buttonProcessCube.Name = "buttonProcessCube";
            this.buttonProcessCube.Size = new System.Drawing.Size(300, 39);
            this.buttonProcessCube.TabIndex = 21;
            this.buttonProcessCube.Text = "Обработать куб";
            this.buttonProcessCube.UseVisualStyleBackColor = true;
            this.buttonProcessCube.Click += new System.EventHandler(this.buttonProcessCube_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(281, 123);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(120, 17);
            this.labelDate.TabIndex = 20;
            this.labelDate.Text = "00.00.0000 00:00";
            // 
            // labelCubes
            // 
            this.labelCubes.AutoSize = true;
            this.labelCubes.Location = new System.Drawing.Point(427, 22);
            this.labelCubes.Name = "labelCubes";
            this.labelCubes.Size = new System.Drawing.Size(46, 17);
            this.labelCubes.TabIndex = 19;
            this.labelCubes.Text = "Кубы:";
            // 
            // labelDimensions
            // 
            this.labelDimensions.AutoSize = true;
            this.labelDimensions.Location = new System.Drawing.Point(18, 22);
            this.labelDimensions.Name = "labelDimensions";
            this.labelDimensions.Size = new System.Drawing.Size(86, 17);
            this.labelDimensions.TabIndex = 18;
            this.labelDimensions.Text = "Измерения:";
            // 
            // comboBoxCubes
            // 
            this.comboBoxCubes.FormattingEnabled = true;
            this.comboBoxCubes.Location = new System.Drawing.Point(430, 53);
            this.comboBoxCubes.Name = "comboBoxCubes";
            this.comboBoxCubes.Size = new System.Drawing.Size(300, 24);
            this.comboBoxCubes.TabIndex = 17;
            this.comboBoxCubes.SelectedIndexChanged += new System.EventHandler(this.comboBoxCubes_SelectedIndexChanged);
            // 
            // comboBoxDimensions
            // 
            this.comboBoxDimensions.FormattingEnabled = true;
            this.comboBoxDimensions.Location = new System.Drawing.Point(21, 53);
            this.comboBoxDimensions.Name = "comboBoxDimensions";
            this.comboBoxDimensions.Size = new System.Drawing.Size(296, 24);
            this.comboBoxDimensions.TabIndex = 16;
            this.comboBoxDimensions.SelectedIndexChanged += new System.EventHandler(this.comboBoxDimensions_SelectedIndexChanged);
            // 
            // buttonProcessDim
            // 
            this.buttonProcessDim.Location = new System.Drawing.Point(21, 259);
            this.buttonProcessDim.Name = "buttonProcessDim";
            this.buttonProcessDim.Size = new System.Drawing.Size(300, 39);
            this.buttonProcessDim.TabIndex = 15;
            this.buttonProcessDim.Text = "Обработать измерение";
            this.buttonProcessDim.UseVisualStyleBackColor = true;
            this.buttonProcessDim.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // labelDateLastProcess
            // 
            this.labelDateLastProcess.AutoSize = true;
            this.labelDateLastProcess.Location = new System.Drawing.Point(18, 120);
            this.labelDateLastProcess.Name = "labelDateLastProcess";
            this.labelDateLastProcess.Size = new System.Drawing.Size(209, 17);
            this.labelDateLastProcess.TabIndex = 14;
            this.labelDateLastProcess.Text = "Дата последнего обновления:";
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(785, 386);
            this.Controls.Add(this.tabControlOverview);
            this.Name = "ConnectForm";
            this.Text = "Управление проектами";
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            this.tabControlOverview.ResumeLayout(false);
            this.tabPageConnect.ResumeLayout(false);
            this.tabPageConnect.PerformLayout();
            this.tabPageGetData.ResumeLayout(false);
            this.tabPageGetData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlOverview;
        private System.Windows.Forms.TabPage tabPageConnect;
        private System.Windows.Forms.TabPage tabPageGetData;
        private System.Windows.Forms.TextBox textBoxAddressServer;
        private System.Windows.Forms.Label labelStrConnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonProcessCube;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelCubes;
        private System.Windows.Forms.Label labelDimensions;
        private System.Windows.Forms.ComboBox comboBoxCubes;
        private System.Windows.Forms.ComboBox comboBoxDimensions;
        private System.Windows.Forms.Button buttonProcessDim;
        private System.Windows.Forms.Label labelDateLastProcess;
    }
}

