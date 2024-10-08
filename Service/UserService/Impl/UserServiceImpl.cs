﻿using Commons.BaseModels;
using Mapper;
using MVC卓越项目.Commons.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class UserServiceImpl : IUserService
    {
        public Hashtable GetBalance(long uid)
        {
            using (var db = new eshoppingEntities())
            {
                var tran = db.Database.BeginTransaction();
                //累计消费
                decimal? orderStatusSum = db.store_order.Where(e => e.uid == uid && e.paid == true).Sum(t => (decimal?)t.pay_price);
                if (orderStatusSum is null)
                {
                    orderStatusSum = new int();
                    orderStatusSum = 0;
                }
                //累计充值
                decimal? recharge = db.user_recharge.Where(e => e.uid == uid).Sum(e => e.price);
                if (recharge is null)
                {
                    recharge = new int();
                    recharge = 0;
                }
                //当前余额
                decimal nowMoney = db.eshop_user.Where(e => e.uid == uid).FirstOrDefault().now_money;
                //订单总数
               int orderSum = db.store_order.Where(e => e.uid == uid && e.paid == true&& e.is_del==false).Count();
                tran.Commit();
                return new Hashtable()
                {
                    {"orderStatusSum",orderStatusSum },
                    {"recharge",recharge },
                    {"nowMoney",nowMoney },
                    {"orderSum",orderSum },
                };

            }
        }

        public eshop_user getUserInfo(long uid)
        {
            using (var db = new eshoppingEntities())
            {
                var result = db.eshop_user.Where(e => e.uid == uid).FirstOrDefault();
                result.password = null;
                return result;
            }
        }

        public PageModel getUsers(QueryData queryData)
        {
            using (var db  = new eshoppingEntities())
            {
                 return    new PageUtils<eshop_user>(queryData.Page, queryData.Limit).StartPage(db.eshop_user.Where(e => e.is_del == false).OrderBy(e => e.uid));
            }
        }

        public void UpdateUserInfo(Dictionary<string, object> eshop_User)
        {
            using (var db = new eshoppingEntities())
            {
                eshop_user User = db.eshop_user.Find(Convert.ToInt64(eshop_User["uid"]));
                User.real_name = eshop_User["real_name"].ToString();
                User.phone = eshop_User["phone"].ToString();
                User.mark = eshop_User["mark"].ToString();
                db.SaveChanges();
            }
        }
    }
}
