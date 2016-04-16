using System;
using System.Dynamic;

namespace Dynamic
{
    class Duck : DynamicObject
    {
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            Console.WriteLine(binder.Name + " was called");
            result = null;
            return true;
        }
    }
}
