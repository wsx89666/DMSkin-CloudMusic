﻿using DMSkin.CloudMusic.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSkin.CloudMusic.API
{
    /// <summary>
    /// 页面管理器
    /// </summary>
    public class PageManager
    {
        #region 本地音乐
        private static PageLocalMusic pageLocalMusic;
        /// <summary>
        /// 本地音乐
        /// </summary>
        public static PageLocalMusic PageLocalMusic
        {
            get
            {
                if (pageLocalMusic == null)
                {
                    //只会被构造一次
                    pageLocalMusic = new PageLocalMusic();
                }
                return pageLocalMusic;
            }
            set { pageLocalMusic = value; }
        }
        #endregion

        public static PageEmpty PageEmpty = new PageEmpty();
    }
}
