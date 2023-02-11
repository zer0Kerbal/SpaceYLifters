/*
	This file is part of SpaceY.Lifters, and is
		©2023 LisiasT : http://lisias.net <support@lisias.net>

	SpaceY.Lifters is
		© 2022-2023 zer0Kerbal
		© 2014-2022 Necrobones

	and licensed as follows:
		* CC-BY-NC-SA-4.0 : https://creativecommons.org/licenses/by-nc-sa/4.0/

	SpaceY.Lifters is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
*/
using System.Collections.Generic;
using UnityEngine;

namespace SpaceY.Lifters
{
	public class ModuleManagerSupport : MonoBehaviour
	{
		public static IEnumerable<string> ModuleManagerAddToModList()
		{
			List<string> list = new List<string>();
			{
				ConfigNode[] cns = GameDatabase.Instance.GetConfigNodes("CUSTOM_PARTLIST_CATEGORY");
				bool found = false;
				foreach (ConfigNode cn in cns) if (cn.HasValue("categoryName") && "SpaceY".Equals(cn.GetValue("categoryName")))
				{
					Debug.Log("[SpaceY.Lifters] CUSTOM_PARTLIST_CATEGORY for SpaceY already found. Avoiding creating it again.");
					found = true;
					break;
				}
				if (!found) list.Add("SpaceYLifters_Category");	
			}
			string[] r = list.ToArray();
			return r;
		}
	}
}
