using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KickOff.Controllers
{
    public class OrderSampleController : ApiController
    {
        [HttpGet]
        public string Index()
        {
            var data = "[ { 	order_id: \"V201256\", 	show_id : 1, 	show_name: \"hidden fortress\",  	target_date: \"10/7/2016\", 	target_time: \"morning\", 	description: \"MAIN CABLE PACKAGE\", 	unpicked: 10,                       	status: \"confirmed\", 	creator: \"John Smith\", 	created_date: \"10/7/2016\" }, { 	order_id: \"V201257\", 	show_id : 1, 	show_name: \"hidden fortress\",  	target_date: \"11/7/2016\", 	target_time: \"morning\", 	description: \"MAIN CABLE PACKAGE\", 	unpicked: 10,                       	status: \"confirmed\", 	creator: \"John Smith 2\", 	created_date: \"11/7/2016\" }, { 	order_id: \"V201258\", 	show_id : 1, 	show_name: \"hidden fortress\",  	target_date: \"12/7/2016\", 	target_time: \"morning\", 	description: \"MAIN CABLE PACKAGE\", 	unpicked: 15,                       	status: \"active\", 	creator: \"John Smith new\", 	created_date: \"12/7/2016\" }, { 	order_id: \"V201259\", 	show_id : 1, 	show_name: \"hidden fortress\",  	target_date: \"10/7/2016\", 	target_time: \"morning\", 	description: \"MAIN CABLE PACKAGE\", 	unpicked: 10,                       	status: \"active\", 	creator: \"John Smith\", 	created_date: \"10/7/2016\" }, { 	order_id: \"V201267\", 	show_id : 1, 	show_name: \"hidden fortress new\",  	target_date: \"11/7/2016\", 	target_time: \"morning\", 	description: \"MAIN CABLE PACKAGE\", 	unpicked: 10,                       	status: \"complete\", 	creator: \"John Smith\", 	created_date: \"11/7/2016\" }, { 	order_id: \"V201268\", 	show_id : 1, 	show_name: \"hidden fortress\",  	target_date: \"12/7/2016\", 	target_time: \"morning\", 	description: \"MAIN CABLE PACKAGE\", 	unpicked: 15,                       	status: \"complete\", 	creator: \"John Smith new\", 	created_date: \"12/7/2016\" }, { 	order_id: \"V201258\", 	show_id : 1, 	show_name: \"hidden fortress new\",  	target_date: \"10/7/2016\", 	target_time: \"morning\", 	description: \"MAIN CABLE PACKAGE\", 	unpicked: 10,                       	status: \"complete\", 	creator: \"John Smith\", 	created_date: \"10/7/2016\" }, { 	order_id: \"V201357\", 	show_id : 1, 	show_name: \"hidden fortress\",  	target_date: \"11/7/2016\", 	target_time: \"morning\", 	description: \"MAIN CABLE PACKAGE\", 	unpicked: 10,                       	status: \"complete\", 	creator: \"John Smith\", 	created_date: \"11/7/2016\" }, { 	order_id: \"V202258\", 	show_id : 1, 	show_name: \"hidden fortress new\",  	target_date: \"12/7/2016\", 	target_time: \"morning\", 	description: \"MAIN CABLE PACKAGE\", 	unpicked: 15,                       	status: \"complete\", 	creator: \"John Smith new\", 	created_date: \"12/7/2016\" }]";
            return data;
        }
    }
}
