﻿using app.web.application.catalogbrowsing.stubs;
using app.web.core;
using app.web.core.aspnet;

namespace app.web.application.catalogbrowsing
{
  public class ViewTheMainDepartmentsInTheStore : ISupportAUserFeature
  {
    IFindInformationInTheStore information_in_the_store_repository;
    IDisplayInformation display_engine;

    public ViewTheMainDepartmentsInTheStore(IFindInformationInTheStore information_in_the_store_repository,
                                            IDisplayInformation display_engine)
    {
      this.information_in_the_store_repository = information_in_the_store_repository;
      this.display_engine = display_engine;
    }

    public ViewTheMainDepartmentsInTheStore() : this(new StubStoreCatalog(),
                                                     new WebFormsDisplayEngine())
    {
    }

    public void process(IEncapsulateRequestDetails request)
    {
      display_engine.display(information_in_the_store_repository.get_the_main_departments());
    }
  }
}