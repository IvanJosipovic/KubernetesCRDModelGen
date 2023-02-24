//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading;
//using Microsoft.CodeAnalysis;
//using NuGet.LibraryModel;
//using NuGet.ProjectModel;
//using NuGet.Versioning;
//using Yardarm.Generation;
//using Basic.Reference.Assemblies;
//using static Basic.Reference.Assemblies.NetStandard20;

//namespace Yardarm.Packaging.Internal
//{
//    internal class LocalNuGetReferenceGenerator : IReferenceGenerator
//    {
//        private const string NetStandardLibrary = "NETStandard.Library";

//        private readonly GenerationContext _context;

//        public LocalNuGetReferenceGenerator(GenerationContext context)
//        {
//            _context = context ?? throw new ArgumentNullException(nameof(context));
//        }

//        public async IAsyncEnumerable<MetadataReference> Generate(CancellationToken cancellationToken = default)
//        {
//            var references = new List<MetadataReference>();

//            references.AddRange(References.All);

//            var assebly = GetType().Assembly;

//            var assemblies = assebly.GetManifestResourceNames().Where(x => x.StartsWith("runtime.") && x.EndsWith(".dll")).ToList();

//            foreach (var item in assemblies) {
//                using var stream = assebly.GetManifestResourceStream(item);
//                var ass = MetadataReference.CreateFromStream(stream);
//                references.Add(ass);
//            }

//            foreach (var item in references) {
//                yield return item;
//            }
//        }
//    }
//}
