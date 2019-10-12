﻿
namespace appAddress.ViewModels
{
    using appAddress.Models;
    using System.Collections.Generic;

    public class MainViewModel
    {

        #region Properties
        public List<Book> ListBook { get; set; }
        #endregion

        #region 
        public BookViewModel bookViewModel { get; set; }

        #endregion

        #region Constructor
        public MainViewModel()
        {
            instance = this;
            this.bookViewModel = new BookViewModel();
        } 
        #endregion

        #region singleton
        private static MainViewModel instance;

        private static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();
            }
            return (instance);
        }
        #endregion
    }
}