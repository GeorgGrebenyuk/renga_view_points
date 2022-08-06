
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
            this.label6 = new System.Windows.Forms.Label();
            this.tb_vp_name = new System.Windows.Forms.TextBox();
            this.start_saving_images = new System.Windows.Forms.Button();
            this.save_image_path = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.images_size = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.update_point = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // start_saving_images
            // 
            this.start_saving_images.Location = new System.Drawing.Point(322, 112);
            this.start_saving_images.Name = "start_saving_images";
            this.start_saving_images.Size = new System.Drawing.Size(75, 23);
            this.start_saving_images.TabIndex = 10;
            this.start_saving_images.Text = "Запуск";
            this.start_saving_images.UseVisualStyleBackColor = true;
            this.start_saving_images.Click += new System.EventHandler(this.start_saving_images_Click);
            // 
            // save_image_path
            // 
            this.save_image_path.Location = new System.Drawing.Point(322, 46);
            this.save_image_path.Name = "save_image_path";
            this.save_image_path.Size = new System.Drawing.Size(75, 23);
            this.save_image_path.TabIndex = 9;
            this.save_image_path.Text = "Обзор";
            this.save_image_path.UseVisualStyleBackColor = true;
            this.save_image_path.Click += new System.EventHandler(this.save_image_path_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Запуск сохранения:";
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
            // images_size
            // 
            this.images_size.FormattingEnabled = true;
            this.images_size.Items.AddRange(new object[] {
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
            this.images_size.Location = new System.Drawing.Point(15, 32);
            this.images_size.Name = "images_size";
            this.images_size.Size = new System.Drawing.Size(134, 121);
            this.images_size.TabIndex = 6;
            this.images_size.SelectedIndexChanged += new System.EventHandler(this.images_size_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сохранить изображение \r\nвыбранной сцены в файл";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.images_size);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Перезаписать выбранную точку обзора";
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
            // LookViewPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(770, 354);
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
        private System.Windows.Forms.ListBox images_size;
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
    }
}