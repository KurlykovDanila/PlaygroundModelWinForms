﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Presenters
{
    class PresenterController : IPresenter
    {
        public PresenterController()
        {
            MakeBindings();
        }

        private void MakeBindings()
        {
            StartPresenter.Redirect += RunModelPresenter;
        }

        public void Run()
        {
            new StartPresenter().Run();
        }

        private void RunModelPresenter()
        {
            new ModelPresenter().Run();
        }
    }
}
