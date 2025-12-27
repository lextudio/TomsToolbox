using System.Collections.Generic;
using Avalonia;
using Avalonia.VisualTree;

namespace TomsToolbox.Wpf.Composition
{
    /// <summary>
    /// Extension methods for visual tree navigation.
    /// </summary>
    public static class VisualExtensions
    {
        /// <summary>
        /// Returns the current object and all its visual ancestors.
        /// </summary>
        public static IEnumerable<AvaloniaObject?> AncestorsAndSelf(this AvaloniaObject? obj)
        {
            if (obj == null)
                yield break;

            var current = obj;
            while (current != null)
            {
                yield return current;
                current = (current as Visual)?.GetVisualParent();
            }
        }
    }
}