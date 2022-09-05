using System.Collections;
using System.Collections.Generic;

namespace InsuranceWebApi.Interface
{
    public interface IPolicy
    {

        public IEnumerable GetPolicyDetails();
        public IEnumerable<policy> GeTPlociyDetailsById(int id);

    }
}
