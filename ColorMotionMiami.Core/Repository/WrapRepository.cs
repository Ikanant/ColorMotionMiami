using ColorMotionMiami.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorMotionMiami.Core.Repository {
    public class WrapRepository {
        private static List<WrapGroup> wrapGroups = new List<WrapGroup>() {
            new WrapGroup() {
                WrapGroupID = 1, Title = "Cars", ImagePath = "",
                    Wraps = new List<Wrap>() {
                         new Wrap {
                             WrapID = 1,
                            Name = "Full Body Wrap",
                            ShortDescription = "Best wrap in America",
                            Description = "Color on demand wrap with ... ",
                            ImagePath = "wrap1",
                            Available = true,
                            PrepTime = 16,
                            Materials = new List<string>(){"Stickes", "Rum", "Other alcoholic beverages"},
                            Price = 120,
                            IsFavorite = true
                         }
                    }
                }

        };

        public List<Wrap> GetAllWraps() {
            IEnumerable<Wrap> wraps =
                from wrapGroup in wrapGroups
                from wrap in wrapGroup.Wraps

                select wrap;
            return wraps.ToList<Wrap>();
        }

        public Wrap GetWrapById(int wrapId) {
            IEnumerable<Wrap> wraps =
                from wrapGroup in wrapGroups
                from wrap in wrapGroup.Wraps
                where wrap.WrapID == wrapId
                select wrap;

            return wraps.FirstOrDefault();
        }

        public List<WrapGroup> GetGroupedWraps (){
            return wrapGroups;
        }

        public List<Wrap> GetWrapsForGroup(int wrapGroupId) {
            var group = wrapGroups.Where(h => h.WrapGroupID == wrapGroupId).First();

            if (group != null) {
                return group.Wraps;
            }

            return null;
        }

        public List<Wrap> GetFavoriteWraps() {
            IEnumerable<Wrap> wraps =
                from wrapGroup in wrapGroups
                from wrap in wrapGroup.Wraps
                where wrap.IsFavorite
                select wrap;

            return wraps.ToList<Wrap>();
        }
    }
}
