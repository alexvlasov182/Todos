using System;

namespace Todos.Classes.Extensions;

public static class ConversionExtensions
{
  public static bool ToBool(this object? value) => value is not null && (bool)value;
}

