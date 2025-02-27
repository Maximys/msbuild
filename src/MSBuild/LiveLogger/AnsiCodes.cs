﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.Build.Logging.LiveLogger;

/// <summary>
/// A collection of standard ANSI/VT100 control codes.
/// </summary>
internal static class AnsiCodes
{
    /// <summary>
    /// The control sequence introducer.
    /// </summary>
    public const string CSI = "\x1b[";

    /// <summary>
    /// Select graphic rendition.
    /// </summary>
    /// <remarks>\
    /// Print <see cref="CSI"/>color-code<see cref="SetColor"/> to change text color.
    /// </remarks>
    public const string SetColor = ";1m";

    /// <summary>
    /// A shortcut to reset color back to normal.
    /// </summary>
    public const string SetDefaultColor = CSI + "m";

    /// <summary>
    /// Non-xterm extension to render a hyperlink.
    /// </summary>
    /// <remarks>
    /// Print <see cref="LinkPrefix"/>url<see cref="LinkInfix"/>text<see cref="LinkSuffix"/> to render a hyperlink.
    /// </remarks>
    public const string LinkPrefix = "\x1b]8;;";

    /// <summary>
    /// <see cref="LinkPrefix"/>
    /// </summary>
    public const string LinkInfix = "\x1b\\";

    /// <summary>
    /// <see cref="LinkPrefix"/>
    /// </summary>
    public const string LinkSuffix = "\x1b]8;;\x1b\\";

    /// <summary>
    /// Moves up the specified number of lines and puts cursor at the beginning of the line.
    /// </summary>
    /// <remarks>
    /// Print <see cref="CSI"/>N<see cref="MoveUpToLineStart"/> to move N lines up.
    /// </remarks>
    public const string MoveUpToLineStart = "F";

    /// <summary>
    /// Moves forward (to the right) the specified number of characters.
    /// </summary>
    /// <remarks>
    /// Print <see cref="CSI"/>N<see cref="MoveForward"/> to move N characters forward.
    /// </remarks>
    public const string MoveForward = "C";

    /// <summary>
    /// Clears everything from cursor to end of screen.
    /// </summary>
    /// <remarks>
    /// Print <see cref="CSI"/><see cref="EraseInDisplay"/> to clear.
    /// </remarks>
    public const string EraseInDisplay = "J";

    /// <summary>
    /// Clears everything from cursor to the end of the current line.
    /// </summary>
    /// <remarks>
    /// Print <see cref="CSI"/><see cref="EraseInLine"/> to clear.
    /// </remarks>
    public const string EraseInLine = "K";

    /// <summary>
    /// Hides the cursor.
    /// </summary>
    public const string HideCursor = "\x1b[?25l";

    /// <summary>
    /// Shows/restores the cursor.
    /// </summary>
    public const string ShowCursor = "\x1b[?25h";
}
