﻿using Mapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
  public  interface IUserService
    {
        /// <summary>
        /// 获取用户消费信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        Hashtable GetBalance(long uid);
        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        eshop_user getUserInfo(long uid);
    }
}
