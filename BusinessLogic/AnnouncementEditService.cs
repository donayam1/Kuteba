using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Domain;
using ViewModels;

namespace BusinessLogic
{
    public class AnnouncementService : IAnnouncementService
    {
        KutebaDatabase kdb;
        
        public AnnouncementService(KutebaDatabase kdb) {
            this.kdb = kdb;
        }

        public Announcemnets EditNewAnnouncement(AnnouncementEditViewModel avm)
        {
            var res = kdb.Announcemnets.Where(a1 => a1.Title == avm.Title).FirstOrDefault();
            if (res == null) {
                Announcemnets ans = new Announcemnets();
                Guid id = new Guid();
                ans.Id = id.ToString();
                ans.Title = avm.Title;
                ans.VisibleDate = avm.VisibleDate.ToString();
                ans.ExpDate = avm.ExpiaryDate.ToString();
                ans.CreatedDate = DateTime.Now.ToLongDateString();
                ans.PictureUrl = avm.PictureUrl;
                ans.Text = avm.ContentDescription;

                kdb.Announcemnets.Add(ans);
                kdb.SaveChanges();
                return res;
            }
            else
                return null;
        }

        public List<Announcemnets> ListAnnouncements()
        {
            List<Announcemnets> ann = new List<Announcemnets>();

            ann = kdb.Announcemnets.Where(x=>DateTime.Compare(DateTime.Parse(x.ExpDate),DateTime.Now)<=0).ToList();
            return ann;
        }
    }
}
