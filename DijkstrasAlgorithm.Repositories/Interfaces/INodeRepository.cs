﻿using DijkstrasAlgorithm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstrasAlgorithm.Repositories.Interfaces
{
    public interface INodeRepository
    {
        List<Node> GetAllNodes();
    }
}
