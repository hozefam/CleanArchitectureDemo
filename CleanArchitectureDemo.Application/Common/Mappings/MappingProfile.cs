﻿using AutoMapper;
using System.Reflection;

namespace CleanArchitectureDemo.Application.Common.Mappings
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			ApplyMappingFromAssembly(Assembly.GetExecutingAssembly());
		}

		private void ApplyMappingFromAssembly(Assembly assembly)
		{
			var types = assembly.GetExportedTypes()
				.Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
				.ToList();

			foreach (var type in types)
			{
				var instance = Activator.CreateInstance(type);
				var methodInfo = type.GetMethod("Mapping") ?? type.GetInterface(typeof(IMapFrom<>).Name)?.GetMethod("Mapping");
				methodInfo?.Invoke(instance, [this]);
			}
		}
	}
}
