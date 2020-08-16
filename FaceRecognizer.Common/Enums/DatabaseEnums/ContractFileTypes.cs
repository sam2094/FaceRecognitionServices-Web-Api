﻿using FaceRecognizer.Common.Attributes;


namespace FaceRecognizer.Common.Enums.DatabaseEnums
{
	public enum ContractFileTypes : byte
	{
		[EnumDescription("Elektron imza üçün ərizə forması")]
		E_SIGNATURE_APPLICATION_FORM = 1,

		[EnumDescription("Elektron imza üçün müqavilə")]
		E_SIGNATURE_CONTRACT,

		[EnumDescription("Abunə müqaviləsi")]
		SUBSCRIPTION_CONTRACT
	}
}
