using ColorMotionMiami.Core.Model;
using ColorMotionMiami.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorMotionMiami.Core.Service {
    public class WrapDataService {
        private static WrapRepository wrapRepository = new WrapRepository();

        public List<Wrap> GetAllWraps() {
            return wrapRepository.GetAllWraps();
        }
        public List<WrapGroup> GetGroupedWraps() {
            return wrapRepository.GetGroupedWraps();
        }
        public List<Wrap> GetWrapsForGroup(int wrapGroupId) {
            return wrapRepository.GetWrapsForGroup(wrapGroupId);
        }
        public List<Wrap> GetFavoriteWraps() {
            return wrapRepository.GetFavoriteWraps();
        }
        public Wrap GetWrapById (int wrapId) {
            return wrapRepository.GetWrapById(wrapId);
        }
    }
}
