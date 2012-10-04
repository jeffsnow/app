using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using app.web.core;
using app.web.application.catalogbrowsing;

namespace app.specs
{
    public class RoleBasedSecuritySpecs
    {
        public abstract class concern : Observes<ISecurityRoles,
                                            RoleBasedSecurity>
        {
        }

        public class when_run : concern
        {
            private Establish c = () =>
                {
                    request = fake.an<IEncapsulateRequestDetails>();
                    product_request = new ViewProductsInADepartmentRequest();


                };

            private Because b = () =>
                                sut.process(request)
        {
            securityRole = "authenticated_customer";
        };



        private It querry_should_fail = () =>
                                        product_request.denied(x => x.canRun(product_request));

            private static string securityRole;
            private static IEncapsulateRequestDetails request;
            static ViewProductsInADepartmentRequest product_request;



        }
    }
}
