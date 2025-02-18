﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UI.Models.Category;

namespace UI.Models
{
    public class CategoryPageModel : ModelBase
    {
        private ObservableCollection<CategoryModel> Data_;
        public ObservableCollection<CategoryModel> Data
        {
            get { return Data_; }
            set { Data_ = value; OnPropertyChanged(); }
        }

        private CategoryModel SelectedItem_;
        public CategoryModel SelectedItem { get { return SelectedItem_; } set { SelectedItem_ = value; OnPropertyChanged(); } }


        private Visibility EditVisibility_ = Visibility.Collapsed;
        public Visibility EditVisibility { get { return EditVisibility_; } set { EditVisibility_ = value; OnPropertyChanged(); } }

        private bool IsCreate_ = false;
        /// <summary>
        /// 是否是创建分类
        /// </summary>
        public bool IsCreate { get { return IsCreate_; } set { IsCreate_ = value; OnPropertyChanged(); } }

        private string EditName_;
        /// <summary>
        /// 编辑分类名称
        /// </summary>
        public string EditName { get { return EditName_; } set { EditName_ = value; OnPropertyChanged(); } }

        private string EditIconFile_;
        /// <summary>
        /// 编辑分类图标
        /// </summary>
        public string EditIconFile
        {
            get { return EditIconFile_; }
            set { EditIconFile_ = value; OnPropertyChanged(); }
        }

        private string EditErrorText_;
        public string EditErrorText
        {
            get { return EditErrorText_; }
            set { EditErrorText_ = value; OnPropertyChanged(); }
        }
        private bool IsEditError_ = false;
        public bool IsEditError { get { return IsEditError_; } set { IsEditError_ = value; OnPropertyChanged(); } }
    }
}