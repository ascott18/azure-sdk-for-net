// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using Azure.ResourceManager.Resources;
using System.Threading.Tasks;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Dns.Models;
using System.Collections.Generic;
using System.Net;

namespace Azure.Management.Dns.Tests
{
    public static class Helper
    {
        public static async Task TryRegisterResourceGroupAsync(ResourceGroupCollection resourceGroupsOperations, string location, string resourceGroupName)
        {
            await resourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new ResourceGroupData(location));
        }
        public static bool AreEqualPrereq(
            Azure.ResourceManager.Dns.Models.Resource first,
            Azure.ResourceManager.Dns.Models.Resource second,
            bool ignoreEtag = false)
        {
            if (first == null || second == null)
            {
                return false;
            }

            if (!String.Equals(first.Location, second.Location, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            if (first.Tags != null && second.Tags != null)
            {
                if (first.Tags.Count != second.Tags.Count)
                {
                    return false;
                }

                foreach (string key in first.Tags.Keys)
                {
                    if (!second.Tags.ContainsKey(key) ||
                        first.Tags[key] != second.Tags[key])
                    {
                        return false;
                    }
                }
            }
            else{
                return false;
            }

            return true;
        }
        public static bool AreEqual(
            Zone first,
            Zone second,
            bool ignoreEtag = false)
        {
            if (!AreEqualPrereq(first, second))
            {
                return false;
            }

            if (first != null && second != null)
            {
                return ignoreEtag || (first.Etag == second.Etag);
            }

            return true;
        }

        public static bool AreEqual(
            RecordSet first,
            RecordSet second,
            bool ignoreEtag = false)
        {
            if (first != null && second != null)
            {
                return (ignoreEtag || (first.Etag == second.Etag))
                       && first.TTL == second.TTL
                       && AreEqual(first.ARecords, second.ARecords)
                       && AreEqual(first.AaaaRecords, second.AaaaRecords)
                       && AreEqual(first.MxRecords, second.MxRecords)
                       && AreEqual(first.NsRecords, second.NsRecords)
                       && AreEqual(first.PtrRecords, second.PtrRecords)
                       && AreEqual(first.SrvRecords, second.SrvRecords)
                       && AreEqual(first.CnameRecord, second.CnameRecord)
                       && AreEqual(first.SoaRecord, second.SoaRecord);
            }

            return true;
        }

        public static bool AreEqual(string first, string second)
        {
            return string.Equals(first, second, StringComparison.OrdinalIgnoreCase);
        }

        public static bool AreEqual(CnameRecord first, CnameRecord second)
        {
            if (first == null && second == null)
            {
                return true;
            }
            else if (first == null || second == null)
            {
                return false;
            }

            return first.Cname == second.Cname;
        }

        public static bool AreEqual(SoaRecord first, SoaRecord second)
        {
            if (first == null && second == null)
            {
                return true;
            }
            else if (first == null || second == null)
            {
                return false;
            }

            return first.Email == second.Email
                   && first.ExpireTime == second.ExpireTime
                   && first.Host == second.Host
                   && first.MinimumTtl == second.MinimumTtl
                   && first.RefreshTime == second.RefreshTime
                   && first.RetryTime == second.RetryTime
                   && first.SerialNumber == second.SerialNumber;
        }

        public static bool AreEqualCount<T>(IList<T> first, IList<T> second)
        {
            if ((first == null || first.Count == 0) &&
                (second == null || second.Count == 0))
            {
                return true;
            }
            else if (first == null || second == null || first.Count == 0 ||
                     second.Count == 0)
            {
                return false;
            }
            else
            {
                return first.Count == second.Count;
            }
        }

        public static bool AreEqual(IList<ARecord> first, IList<ARecord> second)
        {
            if (!AreEqualCount(first, second))
            {
                return false;
            }

            if (first != null && second != null)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    if (first[i].Ipv4Address != second[i].Ipv4Address)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool AreEqual(
            IList<AaaaRecord> first,
            IList<AaaaRecord> second)
        {
            if (!AreEqualCount(first, second))
            {
                return false;
            }

            if (first != null && second != null)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    var firstAddress = IPAddress.Parse(first[i].Ipv6Address);
                    var secondAddress = IPAddress.Parse(second[i].Ipv6Address);
                    if (!firstAddress.Equals(secondAddress))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool AreEqual(
            IList<MxRecord> first,
            IList<MxRecord> second)
        {
            if (!AreEqualCount(first, second))
            {
                return false;
            }

            if (first != null && second != null)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    if (first[i].Exchange != second[i].Exchange
                        || first[i].Preference != second[i].Preference)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool AreEqual(
            IList<NsRecord> first,
            IList<NsRecord> second)
        {
            if (!AreEqualCount(first, second))
            {
                return false;
            }

            if (first != null && second != null)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    if (first[i].Nsdname != second[i].Nsdname)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool AreEqual(
            IList<PtrRecord> first,
            IList<PtrRecord> second)
        {
            if (!AreEqualCount(first, second))
            {
                return false;
            }

            if (first != null && second != null)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    if (first[i].Ptrdname != second[i].Ptrdname)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool AreEqual(
            IList<SrvRecord> first,
            IList<SrvRecord> second)
        {
            if (!AreEqualCount(first, second))
            {
                return false;
            }

            if (first != null && second != null)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    if (first[i].Port != second[i].Port
                        || first[i].Target != second[i].Target
                        || first[i].Weight != second[i].Weight
                        || first[i].Priority != second[i].Priority)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool AreEqual(
            IList<TxtRecord> first,
            IList<TxtRecord> second)
        {
            if (!AreEqualCount(first, second))
            {
                return false;
            }

            if (first != null && second != null)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    if (first[i].Value != second[i].Value)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool AreEqual(
            Azure.ResourceManager.Dns.Models.SubResource first,
            Azure.ResourceManager.Dns.Models.SubResource second)
        {
            if (first != null && second != null)
            {
                return first.Id == second.Id;
            }

            return true;
        }
    }
}
