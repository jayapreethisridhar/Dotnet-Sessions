﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.Models
{
    
        public interface Icrudable
        {
            void Create();
            void Read();
            void Update();
            void Delete();

        }
    }


