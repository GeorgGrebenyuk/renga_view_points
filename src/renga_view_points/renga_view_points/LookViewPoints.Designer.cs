
namespace renga_view_points
{
    partial class LookViewPoints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookViewPoints));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.load_settings = new System.Windows.Forms.Button();
            this.lb_saved_points = new System.Windows.Forms.ListBox();
            this.save_settings = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chb_use_hidden = new System.Windows.Forms.CheckBox();
            this.button_add_point = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_delete_point = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.update_point = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.start_saving_images = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.save_image_path = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_vp_name = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.current_camera = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.save_all = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.FovHorizontal = new System.Windows.Forms.TextBox();
            this.FovVertical = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.focus_edit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.elev_by_level = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.levels = new System.Windows.Forms.ComboBox();
            this.select_size = new System.Windows.Forms.ComboBox();
            this.image_formats = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.load_settings);
            this.groupBox1.Controls.Add(this.lb_saved_points);
            this.groupBox1.Controls.Add(this.save_settings);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель отображения точек обзора:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Загрузить точки обзора из файла:";
            // 
            // load_settings
            // 
            this.load_settings.Location = new System.Drawing.Point(214, 291);
            this.load_settings.Name = "load_settings";
            this.load_settings.Size = new System.Drawing.Size(75, 23);
            this.load_settings.TabIndex = 15;
            this.load_settings.Text = "Загрузить";
            this.load_settings.UseVisualStyleBackColor = true;
            this.load_settings.Click += new System.EventHandler(this.load_settings_Click);
            // 
            // lb_saved_points
            // 
            this.lb_saved_points.FormattingEnabled = true;
            this.lb_saved_points.Location = new System.Drawing.Point(7, 20);
            this.lb_saved_points.Name = "lb_saved_points";
            this.lb_saved_points.Size = new System.Drawing.Size(282, 238);
            this.lb_saved_points.TabIndex = 0;
            this.lb_saved_points.SelectedIndexChanged += new System.EventHandler(this.lb_saved_points_SelectedIndexChanged);
            // 
            // save_settings
            // 
            this.save_settings.Location = new System.Drawing.Point(214, 260);
            this.save_settings.Name = "save_settings";
            this.save_settings.Size = new System.Drawing.Size(75, 23);
            this.save_settings.TabIndex = 14;
            this.save_settings.Text = "Сохранить";
            this.save_settings.UseVisualStyleBackColor = true;
            this.save_settings.Click += new System.EventHandler(this.save_settings_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Сохранить настройки в файл:";
            // 
            // chb_use_hidden
            // 
            this.chb_use_hidden.AutoSize = true;
            this.chb_use_hidden.Location = new System.Drawing.Point(9, 139);
            this.chb_use_hidden.Name = "chb_use_hidden";
            this.chb_use_hidden.Size = new System.Drawing.Size(298, 17);
            this.chb_use_hidden.TabIndex = 0;
            this.chb_use_hidden.Text = "Сохранять в точку обзора только видимые элементы";
            this.chb_use_hidden.UseVisualStyleBackColor = true;
            this.chb_use_hidden.CheckedChanged += new System.EventHandler(this.chb_use_hidden_CheckedChanged);
            // 
            // button_add_point
            // 
            this.button_add_point.Location = new System.Drawing.Point(234, 43);
            this.button_add_point.Name = "button_add_point";
            this.button_add_point.Size = new System.Drawing.Size(75, 23);
            this.button_add_point.TabIndex = 1;
            this.button_add_point.Text = "Добавить";
            this.button_add_point.UseVisualStyleBackColor = true;
            this.button_add_point.Click += new System.EventHandler(this.button_add_point_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить новую точку обзора:";
            // 
            // button_delete_point
            // 
            this.button_delete_point.Location = new System.Drawing.Point(234, 77);
            this.button_delete_point.Name = "button_delete_point";
            this.button_delete_point.Size = new System.Drawing.Size(75, 23);
            this.button_delete_point.TabIndex = 3;
            this.button_delete_point.Text = "Удалить";
            this.button_delete_point.UseVisualStyleBackColor = true;
            this.button_delete_point.Click += new System.EventHandler(this.button_delete_point_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Удалить выбранную точку обзора";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.update_point);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_vp_name);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chb_use_hidden);
            this.groupBox2.Controls.Add(this.button_add_point);
            this.groupBox2.Controls.Add(this.button_delete_point);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(330, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 333);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управляющие команды:";
            // 
            // update_point
            // 
            this.update_point.Location = new System.Drawing.Point(234, 108);
            this.update_point.Name = "update_point";
            this.update_point.Size = new System.Drawing.Size(75, 23);
            this.update_point.TabIndex = 14;
            this.update_point.Text = "Обновить";
            this.update_point.UseVisualStyleBackColor = true;
            this.update_point.Click += new System.EventHandler(this.update_point_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Перезаписать выбранную точку обзора";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.image_formats);
            this.groupBox3.Controls.Add(this.select_size);
            this.groupBox3.Controls.Add(this.save_all);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.start_saving_images);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.save_image_path);
            this.groupBox3.Location = new System.Drawing.Point(9, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 160);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Для сохранения картинок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберите разрешение для фотографии:";
            // 
            // start_saving_images
            // 
            this.start_saving_images.Location = new System.Drawing.Point(322, 122);
            this.start_saving_images.Name = "start_saving_images";
            this.start_saving_images.Size = new System.Drawing.Size(75, 23);
            this.start_saving_images.TabIndex = 10;
            this.start_saving_images.Text = "Запуск";
            this.start_saving_images.UseVisualStyleBackColor = true;
            this.start_saving_images.Click += new System.EventHandler(this.start_saving_images_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сохранить изображение \r\nвыбранной сцены в файл";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Запуск сохранения:";
            // 
            // save_image_path
            // 
            this.save_image_path.Location = new System.Drawing.Point(322, 35);
            this.save_image_path.Name = "save_image_path";
            this.save_image_path.Size = new System.Drawing.Size(75, 23);
            this.save_image_path.TabIndex = 9;
            this.save_image_path.Text = "Обзор";
            this.save_image_path.UseVisualStyleBackColor = true;
            this.save_image_path.Click += new System.EventHandler(this.save_image_path_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Введите наименование новой точки обзора:";
            // 
            // tb_vp_name
            // 
            this.tb_vp_name.Location = new System.Drawing.Point(244, 17);
            this.tb_vp_name.Name = "tb_vp_name";
            this.tb_vp_name.Size = new System.Drawing.Size(150, 20);
            this.tb_vp_name.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.levels);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.elev_by_level);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.focus_edit);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.FovVertical);
            this.groupBox4.Controls.Add(this.FovHorizontal);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.current_camera);
            this.groupBox4.Location = new System.Drawing.Point(13, 352);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(744, 220);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Отображение текущего положения камеры";
            // 
            // current_camera
            // 
            this.current_camera.AllowUserToAddRows = false;
            this.current_camera.AllowUserToDeleteRows = false;
            this.current_camera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.current_camera.Location = new System.Drawing.Point(9, 19);
            this.current_camera.Name = "current_camera";
            this.current_camera.ReadOnly = true;
            this.current_camera.Size = new System.Drawing.Size(399, 97);
            this.current_camera.TabIndex = 0;
            this.current_camera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.current_camera_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(421, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Обновить вид c \r\nновыми параметрами";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(421, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 26);
            this.label11.TabIndex = 3;
            this.label11.Text = "Получить текущие \r\nкоординаты камеры";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Получить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // save_all
            // 
            this.save_all.AutoSize = true;
            this.save_all.Location = new System.Drawing.Point(165, 70);
            this.save_all.Name = "save_all";
            this.save_all.Size = new System.Drawing.Size(135, 17);
            this.save_all.TabIndex = 11;
            this.save_all.Text = "Сохранить все сцены";
            this.save_all.UseVisualStyleBackColor = true;
            this.save_all.CheckedChanged += new System.EventHandler(this.save_all_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Изменение фокусного расстояния:";
            // 
            // FovHorizontal
            // 
            this.FovHorizontal.Location = new System.Drawing.Point(432, 135);
            this.FovHorizontal.Name = "FovHorizontal";
            this.FovHorizontal.ReadOnly = true;
            this.FovHorizontal.Size = new System.Drawing.Size(100, 20);
            this.FovHorizontal.TabIndex = 7;
            this.FovHorizontal.TextChanged += new System.EventHandler(this.FovHorizontal_TextChanged);
            // 
            // FovVertical
            // 
            this.FovVertical.Location = new System.Drawing.Point(602, 135);
            this.FovVertical.Name = "FovVertical";
            this.FovVertical.ReadOnly = true;
            this.FovVertical.Size = new System.Drawing.Size(100, 20);
            this.FovVertical.TabIndex = 8;
            this.FovVertical.TextChanged += new System.EventHandler(this.FovVertical_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(429, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 26);
            this.label13.TabIndex = 9;
            this.label13.Text = "Горизонтальный угол\r\n вида:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(599, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 26);
            this.label14.TabIndex = 10;
            this.label14.Text = "Вертикальный угол \r\nвида:";
            // 
            // focus_edit
            // 
            this.focus_edit.Location = new System.Drawing.Point(214, 122);
            this.focus_edit.Name = "focus_edit";
            this.focus_edit.Size = new System.Drawing.Size(100, 20);
            this.focus_edit.TabIndex = 11;
            this.focus_edit.TextChanged += new System.EventHandler(this.focus_edit_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(326, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "м.";
            // 
            // elev_by_level
            // 
            this.elev_by_level.Location = new System.Drawing.Point(211, 178);
            this.elev_by_level.Name = "elev_by_level";
            this.elev_by_level.Size = new System.Drawing.Size(100, 20);
            this.elev_by_level.TabIndex = 13;
            this.elev_by_level.TextChanged += new System.EventHandler(this.elev_by_level_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Высота над уровнем";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(326, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "м.";
            // 
            // levels
            // 
            this.levels.FormattingEnabled = true;
            this.levels.Location = new System.Drawing.Point(24, 178);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(164, 21);
            this.levels.TabIndex = 16;
            this.levels.SelectedIndexChanged += new System.EventHandler(this.levels_SelectedIndexChanged);
            // 
            // select_size
            // 
            this.select_size.FormattingEnabled = true;
            this.select_size.Items.AddRange(new object[] {
            "320x200",
            "320x240",
            "640x480",
            "720x480",
            "768x576",
            "800x600",
            "800x480",
            "854x480",
            "1024x768",
            "1024x600",
            "1152x768",
            "1200x800",
            "1280x960",
            "1280x1024",
            "1280x720",
            "1280x768",
            "1400x1050",
            "1440x900",
            "1440x960",
            "1600x1200",
            "1680x1050",
            "1920x1080",
            "1920x1200",
            "2048x1536",
            "2560x2048",
            "2560x1600"});
            this.select_size.Location = new System.Drawing.Point(15, 36);
            this.select_size.Name = "select_size";
            this.select_size.Size = new System.Drawing.Size(121, 21);
            this.select_size.TabIndex = 12;
            this.select_size.SelectedIndexChanged += new System.EventHandler(this.select_size_SelectedIndexChanged);
            // 
            // image_formats
            // 
            this.image_formats.FormattingEnabled = true;
            this.image_formats.Items.AddRange(new object[] {
            "PNG",
            "BMP"});
            this.image_formats.Location = new System.Drawing.Point(165, 122);
            this.image_formats.Name = "image_formats";
            this.image_formats.Size = new System.Drawing.Size(121, 21);
            this.image_formats.TabIndex = 13;
            this.image_formats.SelectedIndexChanged += new System.EventHandler(this.image_formats_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(162, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Выбор формата:";
            // 
            // LookViewPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(770, 598);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LookViewPoints";
            this.Text = "Диспетчер точек обзора";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.current_camera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_saved_points;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add_point;
        private System.Windows.Forms.CheckBox chb_use_hidden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_delete_point;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save_image_path;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button start_saving_images;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_vp_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button load_settings;
        private System.Windows.Forms.Button save_settings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button update_point;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView current_camera;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox save_all;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox FovVertical;
        private System.Windows.Forms.TextBox FovHorizontal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox focus_edit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox elev_by_level;
        private System.Windows.Forms.ComboBox levels;
        private System.Windows.Forms.ComboBox select_size;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox image_formats;
    }
}