﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {
        public static List<GuestResponse> responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void addResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
