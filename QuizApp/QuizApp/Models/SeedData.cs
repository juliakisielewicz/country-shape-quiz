﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using QuizApp.Data;
using Microsoft.AspNetCore.Identity;

namespace QuizApp.Models
{
    public static class SeedData
    {
		public static void SeedUsers(UserManager<IdentityUser> userManager)
		{
			if (userManager.FindByEmailAsync("user1.com").Result == null)
			{
				IdentityUser user = new IdentityUser()
				{
					UserName = "user1.com",
					Email = "user1.com"
				};
				
				IdentityResult result = userManager.CreateAsync(user, "User1!").Result;

				if (result.Succeeded)
				{
					userManager.AddToRoleAsync(user, "RegularUser").Wait();
				}
			}


			if (userManager.FindByEmailAsync("admin.com").Result == null)
			{
				IdentityUser user = new IdentityUser()
                {
					UserName = "admin.com",
					Email = "admin.com"
				};

				IdentityResult result = userManager.CreateAsync(user, "Admin1!").Result;

				if (result.Succeeded)
				{
					userManager.AddToRoleAsync(user, "Administrator").Wait();
				}
			}
		}

		public static void SeedRoles(RoleManager<IdentityRole> roleManager)
		{
			if (!roleManager.RoleExistsAsync("RegularUser").Result)
			{
				IdentityRole role = new IdentityRole();
				role.Name = "RegularUser";
				IdentityResult roleResult = roleManager.CreateAsync(role).Result;
			}


			if (!roleManager.RoleExistsAsync("Administrator").Result)
			{
				IdentityRole role = new IdentityRole();
				role.Name = "Administrator";
				IdentityResult roleResult = roleManager.CreateAsync(role).Result;
			}
		}

		public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new QuizAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<QuizAppContext>>()))
            {
                if (context == null || context.Country == null)
                {
                    throw new ArgumentNullException("Null QuizAppContext");
                }

                // Look for any movies.
                if (context.Country.Any())
                {
                    return;   // DB has been seeded
                }

				/*
				context.Roles.AddRange(
					new RoleTypes
                    {
						Name = "Admin",
                    },
					new RoleTypes
                    {
						Name = "RegularUser",
                    }
					);
				*/
                context.Country.AddRange(
                    
					new Country
					{
						country_name = "United Arab Emirates",
						image_name = "ae.png",
					},

new Country
{
	country_name = "Angola",
	image_name = "ao.png",
},

new Country
{
	country_name = "Burkina Faso",
	image_name = "bf.png",
},

new Country
{
	country_name = "Burundi",
	image_name = "bi.png",
},

new Country
{
	country_name = "Benin",
	image_name = "bj.png",
},

new Country
{
	country_name = "Botswana",
	image_name = "bw.png",
},

new Country
{
	country_name = "Democratic Republic Congo",
	image_name = "cd.png",
},

new Country
{
	country_name = "Central African Republic",
	image_name = "cf.png",
},

new Country
{
	country_name = "Congo",
	image_name = "cg.png",
},

new Country
{
	country_name = "Côte d'Ivoire",
	image_name = "ci.png",
},

new Country
{
	country_name = "Cameroon",
	image_name = "cm.png",
},

new Country
{
	country_name = "Cape Verde",
	image_name = "cv.png",
},

new Country
{
	country_name = "Djibouti",
	image_name = "dj.png",
},

new Country
{
	country_name = "Algeria",
	image_name = "dz.png",
},

new Country
{
	country_name = "Egypt",
	image_name = "eg.png",
},

new Country
{
	country_name = "Western Sahara",
	image_name = "eh.png",
},

new Country
{
	country_name = "Eritrea",
	image_name = "er.png",
},

new Country
{
	country_name = "Ethiopia",
	image_name = "et.png",
},

new Country
{
	country_name = "Gabon",
	image_name = "ga.png",
},

new Country
{
	country_name = "Ghana",
	image_name = "gh.png",
},

new Country
{
	country_name = "Gambia",
	image_name = "gm.png",
},

new Country
{
	country_name = "Guinea",
	image_name = "gn.png",
},

new Country
{
	country_name = "Equatorial Guinea",
	image_name = "gq.png",
},

new Country
{
	country_name = "Guinea-Bissau",
	image_name = "gw.png",
},

new Country
{
	country_name = "Kenya",
	image_name = "ke.png",
},

new Country
{
	country_name = "Comoros",
	image_name = "km.png",
},

new Country
{
	country_name = "Liberia",
	image_name = "lr.png",
},

new Country
{
	country_name = "Lesotho",
	image_name = "ls.png",
},

new Country
{
	country_name = "Libya",
	image_name = "ly.png",
},

new Country
{
	country_name = "Morocco",
	image_name = "ma.png",
},

new Country
{
	country_name = "Madagascar",
	image_name = "mg.png",
},

new Country
{
	country_name = "Mali",
	image_name = "ml.png",
},

new Country
{
	country_name = "Mauritania",
	image_name = "mr.png",
},

new Country
{
	country_name = "Mauritius",
	image_name = "mu.png",
},

new Country
{
	country_name = "Malawi",
	image_name = "mw.png",
},

new Country
{
	country_name = "Mozambique",
	image_name = "mz.png",
},

new Country
{
	country_name = "Namibia",
	image_name = "na.png",
},

new Country
{
	country_name = "Niger",
	image_name = "ne.png",
},

new Country
{
	country_name = "Nigeria",
	image_name = "ng.png",
},

new Country
{
	country_name = "Réunion",
	image_name = "re.png",
},

new Country
{
	country_name = "Rwanda",
	image_name = "rw.png",
},

new Country
{
	country_name = "Seychelles",
	image_name = "sc.png",
},

new Country
{
	country_name = "Sudan",
	image_name = "sd.png",
},

new Country
{
	country_name = "Saint Helena",
	image_name = "sh.png",
},

new Country
{
	country_name = "Sierra Leone",
	image_name = "sl.png",
},

new Country
{
	country_name = "Senegal",
	image_name = "sn.png",
},

new Country
{
	country_name = "Somalia",
	image_name = "so.png",
},

new Country
{
	country_name = "South Sudan",
	image_name = "ss.png",
},

new Country
{
	country_name = "Sao Tome and Principe",
	image_name = "st.png",
},

new Country
{
	country_name = "Swaziland",
	image_name = "sz.png",
},

new Country
{
	country_name = "Chad",
	image_name = "td.png",
},

new Country
{
	country_name = "Togo",
	image_name = "tg.png",
},

new Country
{
	country_name = "Tunisia",
	image_name = "tn.png",
},

new Country
{
	country_name = "Tanzania",
	image_name = "tz.png",
},

new Country
{
	country_name = "Uganda",
	image_name = "ug.png",
},

new Country
{
	country_name = "Mayotte",
	image_name = "yt.png",
},

new Country
{
	country_name = "South Africa",
	image_name = "za.png",
},

new Country
{
	country_name = "Zambia",
	image_name = "zm.png",
},

new Country
{
	country_name = "Zimbabwe",
	image_name = "zw.png",
},

new Country
{
	country_name = "Afghanistan",
	image_name = "af.png",
},

new Country
{
	country_name = "Armenia",
	image_name = "am.png",
},

new Country
{
	country_name = "Antartica",
	image_name = "aq.png",
},

new Country
{
	country_name = "Azerbaijan",
	image_name = "az.png",
},

new Country
{
	country_name = "Bangladesh",
	image_name = "bd.png",
},

new Country
{
	country_name = "Bahrain",
	image_name = "bh.png",
},

new Country
{
	country_name = "Brunei Darussalam",
	image_name = "bn.png",
},

new Country
{
	country_name = "Bhutan",
	image_name = "bt.png",
},

new Country
{
	country_name = "Bouvet Island",
	image_name = "bv.png",
},

new Country
{
	country_name = "Cocos (Keeling) Islands",
	image_name = "cc.png",
},

new Country
{
	country_name = "China",
	image_name = "cn.png",
},

new Country
{
	country_name = "Cyprus",
	image_name = "cy.png",
},

new Country
{
	country_name = "Christmas Island",
	image_name = "cx.png",
},

new Country
{
	country_name = "Georgia",
	image_name = "ge.png",
},

new Country
{
	country_name = "South Georgia and the South Sandwich Islands",
	image_name = "gs.png",
},

new Country
{
	country_name = "Hong Kong",
	image_name = "hk.png",
},

new Country
{
	country_name = "Heard Island and McDonald Islands",
	image_name = "hm.png",
},

new Country
{
	country_name = "Indonesia",
	image_name = "id.png",
},

new Country
{
	country_name = "Israel",
	image_name = "il.png",
},

new Country
{
	country_name = "British Indian Ocean Territory",
	image_name = "io.png",
},

new Country
{
	country_name = "India",
	image_name = "in.png",
},

new Country
{
	country_name = "Iraq",
	image_name = "iq.png",
},

new Country
{
	country_name = "Iran",
	image_name = "ir.png",
},

new Country
{
	country_name = "Jordan",
	image_name = "jo.png",
},

new Country
{
	country_name = "Japan",
	image_name = "jp.png",
},

new Country
{
	country_name = "Kyrgyzstan",
	image_name = "kg.png",
},

new Country
{
	country_name = "Cambodia",
	image_name = "kh.png",
},

new Country
{
	country_name = "North Korea",
	image_name = "kp.png",
},

new Country
{
	country_name = "South Korea",
	image_name = "kr.png",
},

new Country
{
	country_name = "Kuwait",
	image_name = "kw.png",
},

new Country
{
	country_name = "Kazakhstan",
	image_name = "kz.png",
},

new Country
{
	country_name = "Lao People Democratic Republic",
	image_name = "la.png",
},

new Country
{
	country_name = "Lebanon",
	image_name = "lb.png",
},

new Country
{
	country_name = "Sri Lanka",
	image_name = "lk.png",
},

new Country
{
	country_name = "Myanmar",
	image_name = "mm.png",
},

new Country
{
	country_name = "Mongolia",
	image_name = "mn.png",
},

new Country
{
	country_name = "Macao",
	image_name = "mo.png",
},

new Country
{
	country_name = "Maldives",
	image_name = "mv.png",
},

new Country
{
	country_name = "Malaysia",
	image_name = "my.png",
},

new Country
{
	country_name = "New Caledonia",
	image_name = "nc.png",
},

new Country
{
	country_name = "Nepal",
	image_name = "np.png",
},

new Country
{
	country_name = "Oman",
	image_name = "om.png",
},

new Country
{
	country_name = "Philippines",
	image_name = "ph.png",
},

new Country
{
	country_name = "Pakistan",
	image_name = "pk.png",
},

new Country
{
	country_name = "Qatar",
	image_name = "qa.png",
},

new Country
{
	country_name = "Russian federation",
	image_name = "ru.png",
},

new Country
{
	country_name = "Saudi Arabia",
	image_name = "sa.png",
},

new Country
{
	country_name = "Singapore",
	image_name = "sg.png",
},

new Country
{
	country_name = "Suriname",
	image_name = "sr.png",
},

new Country
{
	country_name = "Syrian Arab Republic",
	image_name = "sy.png",
},

new Country
{
	country_name = "French Southern Territories",
	image_name = "tf.png",
},

new Country
{
	country_name = "Thailand",
	image_name = "th.png",
},

new Country
{
	country_name = "Tajikistan",
	image_name = "tj.png",
},

new Country
{
	country_name = "Timor-Leste",
	image_name = "tl.png",
},

new Country
{
	country_name = "Turkmenistan",
	image_name = "tm.png",
},

new Country
{
	country_name = "Turkey",
	image_name = "tr.png",
},

new Country
{
	country_name = "Taiwan",
	image_name = "tw.png",
},

new Country
{
	country_name = "Uzbekistan",
	image_name = "uz.png",
},

new Country
{
	country_name = "Viet Nam",
	image_name = "vn.png",
},

new Country
{
	country_name = "Yemen",
	image_name = "ye.png",
},

new Country
{
	country_name = "Andorra",
	image_name = "ad.png",
},

new Country
{
	country_name = "Albania",
	image_name = "al.png",
},

new Country
{
	country_name = "Austria",
	image_name = "at.png",
},

new Country
{
	country_name = "Aland Islands",
	image_name = "ax.png",
},

new Country
{
	country_name = "Bosnia and Herzegovina",
	image_name = "ba.png",
},

new Country
{
	country_name = "Belgium",
	image_name = "be.png",
},

new Country
{
	country_name = "Bulgaria",
	image_name = "bg.png",
},

new Country
{
	country_name = "Belarus",
	image_name = "by.png",
},

new Country
{
	country_name = "Switzerland",
	image_name = "ch.png",
},

new Country
{
	country_name = "Czech Republic",
	image_name = "cz.png",
},

new Country
{
	country_name = "Germany",
	image_name = "de.png",
},

new Country
{
	country_name = "Denmark",
	image_name = "dk.png",
},

new Country
{
	country_name = "Estonia",
	image_name = "ee.png",
},

new Country
{
	country_name = "Spain",
	image_name = "es.png",
},

new Country
{
	country_name = "Finland",
	image_name = "fi.png",
},

new Country
{
	country_name = "France",
	image_name = "fr.png",
},

new Country
{
	country_name = "Faroe Islands",
	image_name = "fo.png",
},

new Country
{
	country_name = "United Kingdom",
	image_name = "gb.png",
},

new Country
{
	country_name = "Guernsey",
	image_name = "gg.png",
},

new Country
{
	country_name = "Gibraltar",
	image_name = "gi.png",
},

new Country
{
	country_name = "Greece",
	image_name = "gr.png",
},

new Country
{
	country_name = "Croatia",
	image_name = "hr.png",
},

new Country
{
	country_name = "Hungary",
	image_name = "hu.png",
},

new Country
{
	country_name = "Ireland",
	image_name = "ie.png",
},

new Country
{
	country_name = "Isle of Man",
	image_name = "im.png",
},

new Country
{
	country_name = "Iceland",
	image_name = "is.png",
},

new Country
{
	country_name = "Italy",
	image_name = "it.png",
},

new Country
{
	country_name = "Liechtenstein",
	image_name = "li.png",
},

new Country
{
	country_name = "Lithuania",
	image_name = "lt.png",
},

new Country
{
	country_name = "Luxembourg",
	image_name = "lu.png",
},

new Country
{
	country_name = "Latvia",
	image_name = "lv.png",
},

new Country
{
	country_name = "Monaco",
	image_name = "mc.png",
},

new Country
{
	country_name = "Moldova",
	image_name = "md.png",
},

new Country
{
	country_name = "Montenegro",
	image_name = "me.png",
},

new Country
{
	country_name = "Macedonia",
	image_name = "mk.png",
},

new Country
{
	country_name = "Malta",
	image_name = "mt.png",
},

new Country
{
	country_name = "Netherlands",
	image_name = "nl.png",
},

new Country
{
	country_name = "Norway",
	image_name = "no.png",
},

new Country
{
	country_name = "Poland",
	image_name = "pl.png",
},

new Country
{
	country_name = "Portugal",
	image_name = "pt.png",
},

new Country
{
	country_name = "Romania",
	image_name = "ro.png",
},

new Country
{
	country_name = "Serbia",
	image_name = "rs.png",
},

new Country
{
	country_name = "Sweden",
	image_name = "se.png",
},

new Country
{
	country_name = "Slovenia",
	image_name = "si.png",
},

new Country
{
	country_name = "Svalbard and Jan Mayen",
	image_name = "sj.png",
},

new Country
{
	country_name = "Slovakia",
	image_name = "sk.png",
},

new Country
{
	country_name = "San Marino",
	image_name = "sm.png",
},

new Country
{
	country_name = "Ukraine",
	image_name = "ua.png",
},

new Country
{
	country_name = "Vatican City State",
	image_name = "va.png",
},

new Country
{
	country_name = "Antigua and Barbuda",
	image_name = "ag.png",
},

new Country
{
	country_name = "Anguilla",
	image_name = "ai.png",
},

new Country
{
	country_name = "Aruba",
	image_name = "aw.png",
},

new Country
{
	country_name = "Barbados",
	image_name = "bb.png",
},

new Country
{
	country_name = "Saint Barthélemy",
	image_name = "bl.png",
},

new Country
{
	country_name = "Bermuda",
	image_name = "bm.png",
},

new Country
{
	country_name = "Bonaire Sint Eustatius and Saba",
	image_name = "bq.png",
},

new Country
{
	country_name = "Bahamas",
	image_name = "bs.png",
},

new Country
{
	country_name = "Belize",
	image_name = "bz.png",
},

new Country
{
	country_name = "Canada",
	image_name = "ca.png",
},

new Country
{
	country_name = "Costa Rica",
	image_name = "cr.png",
},

new Country
{
	country_name = "Cuba",
	image_name = "cu.png",
},

new Country
{
	country_name = "Curaçao",
	image_name = "cw.png",
},

new Country
{
	country_name = "Dominica",
	image_name = "dm.png",
},

new Country
{
	country_name = "Dominican Republic",
	image_name = "do.png",
},

new Country
{
	country_name = "Grenada",
	image_name = "gd.png",
},

new Country
{
	country_name = "Greenland",
	image_name = "gl.png",
},

new Country
{
	country_name = "Guadeloupe",
	image_name = "gp.png",
},

new Country
{
	country_name = "Guatemala",
	image_name = "gt.png",
},

new Country
{
	country_name = "Honduras",
	image_name = "hn.png",
},

new Country
{
	country_name = "Haiti",
	image_name = "ht.png",
},

new Country
{
	country_name = "Jamaica",
	image_name = "jm.png",
},

new Country
{
	country_name = "Saint Kitts and Nevis",
	image_name = "kn.png",
},

new Country
{
	country_name = "Cayman Islands",
	image_name = "ky.png",
},

new Country
{
	country_name = "Saint Lucia",
	image_name = "lc.png",
},

new Country
{
	country_name = "Saint Martin (french)",
	image_name = "mf.png",
},

new Country
{
	country_name = "Martinique",
	image_name = "mq.png",
},

new Country
{
	country_name = "Montserrat",
	image_name = "ms.png",
},

new Country
{
	country_name = "Mexico",
	image_name = "mx.png",
},

new Country
{
	country_name = "Panama",
	image_name = "pa.png",
},

new Country
{
	country_name = "Saint Pierre and Miquelon",
	image_name = "pm.png",
},

new Country
{
	country_name = "Puerto Rico",
	image_name = "pr.png",
},

new Country
{
	country_name = "El Salvador",
	image_name = "sv.png",
},

new Country
{
	country_name = "Sint Maarten",
	image_name = "sx.png",
},

new Country
{
	country_name = "Turks and Caicos Islands",
	image_name = "tc.png",
},

new Country
{
	country_name = "Trinidad and Tobago",
	image_name = "tt.png",
},

new Country
{
	country_name = "United States",
	image_name = "us.png",
},

new Country
{
	country_name = "Saint Vincent and the Grenadines",
	image_name = "vc.png",
},

new Country
{
	country_name = "Virgin Islands - British",
	image_name = "vg.png",
},

new Country
{
	country_name = "Virgin Islands US",
	image_name = "vi.png",
},

new Country
{
	country_name = "American Samoa",
	image_name = "as.png",
},

new Country
{
	country_name = "Australia",
	image_name = "au.png",
},

new Country
{
	country_name = "Cook Islands",
	image_name = "ck.png",
},

new Country
{
	country_name = "Fiji",
	image_name = "fj.png",
},

new Country
{
	country_name = "Guam",
	image_name = "gu.png",
},

new Country
{
	country_name = "Kiribati",
	image_name = "ki.png",
},

new Country
{
	country_name = "Norfolk Island",
	image_name = "nf.png",
},

new Country
{
	country_name = "Nauru",
	image_name = "nr.png",
},

new Country
{
	country_name = "Niue",
	image_name = "nu.png",
},

new Country
{
	country_name = "New Zealand",
	image_name = "nz.png",
},

new Country
{
	country_name = "French Polynesia",
	image_name = "pf.png",
},

new Country
{
	country_name = "Papua New Guinea",
	image_name = "pg.png",
},

new Country
{
	country_name = "Pitcairn",
	image_name = "pn.png",
},

new Country
{
	country_name = "Palau",
	image_name = "pw.png",
},

new Country
{
	country_name = "Solomon Islands",
	image_name = "sb.png",
},

new Country
{
	country_name = "Tokelau",
	image_name = "tk.png",
},

new Country
{
	country_name = "Tonga",
	image_name = "to.png",
},

new Country
{
	country_name = "Vanuatu",
	image_name = "vu.png",
},

new Country
{
	country_name = "Wallis and Futuna",
	image_name = "wf.png",
},

new Country
{
	country_name = "Samoa",
	image_name = "ws.png",
},

new Country
{
	country_name = "Argentina",
	image_name = "ar.png",
},

new Country
{
	country_name = "Bolivia",
	image_name = "bo.png",
},

new Country
{
	country_name = "Brazil",
	image_name = "br.png",
},

new Country
{
	country_name = "Chile",
	image_name = "cl.png",
},

new Country
{
	country_name = "Colombia",
	image_name = "co.png",
},

new Country
{
	country_name = "Ecuador",
	image_name = "ec.png",
},

new Country
{
	country_name = "Falkland Islands",
	image_name = "fk.png",
},

new Country
{
	country_name = "French Guiana",
	image_name = "gf.png",
},

new Country
{
	country_name = "Guyana",
	image_name = "gy.png",
},

new Country
{
	country_name = "Nicaragua",
	image_name = "ni.png",
},

new Country
{
	country_name = "Peru",
	image_name = "pe.png",
},

new Country
{
	country_name = "Paraguay",
	image_name = "py.png",
},

new Country
{
	country_name = "Uruguay",
	image_name = "uy.png",
},

new Country
{
	country_name = "Venezuela",
	image_name = "ve.png",
}

				);
                context.SaveChanges();
            }
        }
    }
}