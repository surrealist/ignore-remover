using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RemoveIgnoreFiles {
  class Program {
    private readonly static string[] IgnoreFolderNames = new string[] {
      "obj", "bin", "packages",
      "node_modules", "bower_components", "jspm_packages"
    };

    private static int count = 0;
    private static string startPath;
    private static int startPathLength;

    static void Main(string[] args) {

      Console.WriteLine("GreatFriends - Remove Ignore Folders");
      Console.WriteLine();

      if (args.Length > 0) {
        startPath = args[0];
      }
      else {
        startPath = Directory.GetCurrentDirectory();
      }

      startPathLength = startPath.Length;

      var d = new DirectoryInfo(startPath);
      Console.WriteLine($"{d.FullName}");

      RemoveIgnores(d);

      Console.WriteLine();
      Console.WriteLine($"{count} folder deleted.");
    }

    private static void RemoveIgnores(DirectoryInfo d, string prefix = "") {

      foreach (var ignoreFolder in IgnoreFolderNames) {
        var xfolders = d.GetDirectories(ignoreFolder);
        foreach (var folder in xfolders) {
          try {
            folder.Delete(recursive: true);
            count++;
            Console.WriteLine($"{prefix}{folder.FullName.Substring(startPathLength, folder.FullName.Length - startPathLength)}");
          }
          catch (Exception ex) {
            Console.WriteLine($"{prefix}**Error: {ex.Message}");
          }
        }
      }


      foreach (var folder in d.GetDirectories()) {
        RemoveIgnores(folder, prefix + "  ");
      }
    }
  }
}