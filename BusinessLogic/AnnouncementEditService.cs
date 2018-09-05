using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Domain;
using ViewModels;
using ObjectMapper;

namespace BusinessLogic
{
    public class AnnouncementService : IAnnouncementService
    {
        KutebaDatabase kdb;
        
        public AnnouncementService(KutebaDatabase kdb) {
            this.kdb = kdb;
        }

        public Announcemnets EditNewAnnouncement(AnnouncementViewModel avm)
        {
            var res = kdb.Announcemnets.Where(a1 => a1.Title == avm.Title).FirstOrDefault();
            if (res == null) {
                Announcemnets ans = avm.ToDomainModel();// new Announcemnets();
                Guid id = Guid.NewGuid();
                ans.Id = id.ToString();
                //ans.Title = avm.Title;
                //ans.VisibleDate = avm.VisibleDate.ToString();
                //ans.ExpDate = avm.ExpiaryDate.ToString();
                //ans.CreatedDate = DateTime.Now.ToLongDateString();
                //ans.PictureUrl = avm.PictureUrl;
                //ans.Text = avm.ContentDescription;

                kdb.Announcemnets.Add(ans);
                kdb.SaveChanges();
                return ans;
            }
            else
                return res;
        }

        public List<Announcemnets> ListAnnouncements()
        {
            List<Announcemnets> ann = new List<Announcemnets>();

            var ann2 = kdb.Announcemnets.Where(x=>true) .ToList();
            foreach (var v in ann2)
            {
                if (DateTime.Compare(DateTime.Parse(v.ExpDate), DateTime.Now) <= 0)
                {
                    ann.Add(v);
                }
            }
            return ann;
        }
    }
}