namespace MoiteRecepti.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MoiteRecepti.Web.ViewModels.Home;

    public interface IGetCountsService
    {
        // 1. Use ViewModel
        IndexViewModel GetCounts();
    }
}
