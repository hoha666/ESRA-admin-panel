using System.Collections.Generic;
using System.Linq;



namespace WebWare.Models.MobileIntroduction
{
    public class TotalMobileIntroduction
    {
        public List<MobileIntroduction> Total { get; set; }
        public TotalMobileIntroduction(ipdbContext context, bool mode)//true : mobile games that already have introductions
        {
            Total = new List<MobileIntroduction>();
            if (mode)
            {
                var Games = (from a in context.TblGame
                             join
                             b in context.TblVersion on a.Id equals b.IdGame
                             join
                             c in context.TblVersionEsra on b.Id equals c.IdVersion
                             join
                             d in context.TblPlatform on b.IdPlatform equals d.Id
                             join
                             e in context.TblVersionPublisherProducer on b.Id equals e.VersionId
                             join
                             f in context.TblVersionScreenshot on b.Id equals f.IdVersion
                             join
                             g in context.TblFile on f.IdFile equals g.Id
                             join
                             h in context.TblScreenshotType on f.IdScreenshotType equals h.Id
                             join
                             i in context.Organizations on e.ObjectId equals i.Id
                             join
                             j in context.TblEsra on c.IdEsra equals j.Id
                             join
                             k in context.TblVersionGenre on b.Id equals k.IdVersion
                             where (d.Id == 8 || d.Id == 9) && (a.ShowInEsraWebsite == true) &&
                             (a.IsInIntroduction == true)
                             && (c.IdEsraType == 3) && (c.IdEsraStatus == 1) /*&& (h.Id == 7)*/
                             select new
                             {
                                 Gname = a.Name,
                                 GID = a.Id,
                                 VID = b.Id,
                                 platform = d.Name,
                                 year = b.ReleaseDateTime.Value.Year,
                                 publisherName = i.Name,
                                 ageRating = j.Age,
                                 Introduction = b.IntroductionMin,
                                 coverPic = g.Name,
                                 isInIntroduction = a.IsInIntroduction
                             }).OrderByDescending(x => x.GID).ToList();
                Games = Games.GroupBy(x => x.VID).Select(g => g.First()).ToList();
                for (var i = 0; i < Games.Count; i++)
                {
                    MobileIntroduction temp = new MobileIntroduction();
                    temp.ageRating = Games[i].ageRating;
                    temp.gameIdReal = Games[i].GID;
                    temp.gameTitle = Games[i].Gname;
                    temp.gameVersionId = Games[i].VID;
                    temp.IntroductionMin = Games[i].Introduction;
                    if (Games[i].isInIntroduction != null && Games[i].isInIntroduction is true)
                        temp.isInIntroduction = true;
                    else temp.isInIntroduction = false;
                    temp.platform = Games[i].platform;
                    temp.year = Games[i].year;

                    Total.Add(temp);

                }
            }
            else
            {
                var Games = (from a in context.TblGame
                             join
                             b in context.TblVersion on a.Id equals b.IdGame
                             join
                             c in context.TblVersionEsra on b.Id equals c.IdVersion
                             join
                             d in context.TblPlatform on b.IdPlatform equals d.Id
                             join
                             j in context.TblEsra on c.IdEsra equals j.Id
                             join
                             k in context.TblVersionGenre on b.Id equals k.IdVersion
                             where (d.Id == 8 || d.Id == 9) && (a.ShowInEsraWebsite == true) &&
                             (a.IsInIntroduction == false || a.IsInIntroduction == null)
                             && (c.IdEsraType == 3) && (c.IdEsraStatus == 1)
                             select new
                             {
                                 Gname = a.Name,
                                 GID = a.Id,
                                 VID = b.Id,
                                 platform = d.Name,
                                 year = b.ReleaseDateTime.Value.Year,
                                 ageRating = j.Age,
                                 Introduction = b.IntroductionMin,
                                 isInIntroduction = a.IsInIntroduction
                             }).OrderByDescending(x => x.GID).ToList();
                for (var i = 0; i < Games.Count; i++)
                {
                    MobileIntroduction temp = new MobileIntroduction();
                    temp.ageRating = Games[i].ageRating;
                    temp.gameIdReal = Games[i].GID;
                    temp.gameTitle = Games[i].Gname;
                    temp.gameVersionId = Games[i].VID;
                    temp.IntroductionMin = Games[i].Introduction;
                    if (Games[i].isInIntroduction != null && Games[i].isInIntroduction is true)
                        temp.isInIntroduction = true;
                    else temp.isInIntroduction = false;
                    temp.platform = Games[i].platform;
                    temp.year = Games[i].year;

                    Total.Add(temp);

                }

            }
        }
    }
}
