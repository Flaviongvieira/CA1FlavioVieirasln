using CA1FlavioVieira.Models;
using Microsoft.Extensions.FileSystemGlobbing;
using System.Text.RegularExpressions;

namespace CA1FlavioVieira.Repository
{
    public class MockDB : IRepository
    {
        // create a list in lieu of DB
        private static List<Package> Packages = new List<Package>()
        {
            new Package()
            {
                PackageId = 1,
                ClientName = "Flavio Vieira",
                Weight = 5,
                Height = 20,
                Length = 10,
                Width = 10,
                ShippingAddress = "Dublin 7, Ireland"
            }
        };

        public void AddPackage(Package package)
        {
            Packages.Add(package);
        }

        public List<Package> DisplayPackages()
        {
            return Packages;
        }

        public Package GetPackage(int id)
        {
            var found = Packages.Find(x => x.PackageId == id);
            return found;
        }

        public ShippingInfo ShippingInfo(Package package)
        {
            var shippingInfo = new ShippingInfo();
            var found = package;
            shippingInfo.PackageId = found.PackageId;
            shippingInfo.ShippingAddress = found.ShippingAddress;
            shippingInfo.Volume = found.Length * found.Width * found.Height;
            shippingInfo.Density = found.Weight/shippingInfo.Volume;
            if (shippingInfo.Density < 1) { shippingInfo.ShippingCategory = "Low"; }
            else if (shippingInfo.Density < 100) { shippingInfo.ShippingCategory = "Medium"; }
            else { shippingInfo.ShippingCategory = "High"; }

            return shippingInfo;
        }

        public void UpdatePackage(Package package)
        {
            var found = Packages.Find(x => x.PackageId == package.PackageId);
            if (found != null)
            {
                found.ShippingAddress = package.ShippingAddress;
                found.ClientName = package.ClientName;
                found.Weight = package.Weight;
                found.Width = package.Width;
                found.Height = package.Height;
                found.Length = package.Length;
            }
        }
    }
}
