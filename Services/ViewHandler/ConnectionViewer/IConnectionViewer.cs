﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ViewHandler.ConnectionViewer
{
    public interface IConnectionViewer
    {
        public List<RelationshipConnection> ViewConnectionList();
    }
}