using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InjectionLifeCycle.Services
{
    public class SampleService:ISingletonService,IScopedService,ITransientService
    {
        Guid _id;
        public SampleService()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return _id;
        }
    }
    public interface ISingletonService
    {
        Guid GetId();
    }
    public interface IScopedService
    {
        Guid GetId();
    }
    public interface ITransientService 
    {
        Guid GetId();
    }

}
