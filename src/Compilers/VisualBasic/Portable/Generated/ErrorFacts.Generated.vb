﻿Namespace Microsoft.CodeAnalysis.VisualBasic
    Friend Partial Module ErrorFacts
        Public Function IsWarning(code as ERRID) As Boolean
            Select Case code
                Case ERRID.WRN_BadSwitch,
                     ERRID.WRN_NoConfigInResponseFile,
                     ERRID.WRN_IgnoreModuleManifest,
                     ERRID.WRN_BadUILang,
                     ERRID.WRN_UseOfObsoleteSymbol2,
                     ERRID.WRN_InvalidOverrideDueToTupleNames2,
                     ERRID.WRN_MustOverloadBase4,
                     ERRID.WRN_OverrideType5,
                     ERRID.WRN_MustOverride2,
                     ERRID.WRN_DefaultnessShadowed4,
                     ERRID.WRN_UseOfObsoleteSymbolNoMessage1,
                     ERRID.WRN_AssemblyGeneration0,
                     ERRID.WRN_AssemblyGeneration1,
                     ERRID.WRN_ComClassNoMembers1,
                     ERRID.WRN_SynthMemberShadowsMember5,
                     ERRID.WRN_MemberShadowsSynthMember6,
                     ERRID.WRN_SynthMemberShadowsSynthMember7,
                     ERRID.WRN_UseOfObsoletePropertyAccessor3,
                     ERRID.WRN_UseOfObsoletePropertyAccessor2,
                     ERRID.WRN_FieldNotCLSCompliant1,
                     ERRID.WRN_BaseClassNotCLSCompliant2,
                     ERRID.WRN_ProcTypeNotCLSCompliant1,
                     ERRID.WRN_ParamNotCLSCompliant1,
                     ERRID.WRN_InheritedInterfaceNotCLSCompliant2,
                     ERRID.WRN_CLSMemberInNonCLSType3,
                     ERRID.WRN_NameNotCLSCompliant1,
                     ERRID.WRN_EnumUnderlyingTypeNotCLS1,
                     ERRID.WRN_NonCLSMemberInCLSInterface1,
                     ERRID.WRN_NonCLSMustOverrideInCLSType1,
                     ERRID.WRN_ArrayOverloadsNonCLS2,
                     ERRID.WRN_RootNamespaceNotCLSCompliant1,
                     ERRID.WRN_RootNamespaceNotCLSCompliant2,
                     ERRID.WRN_GenericConstraintNotCLSCompliant1,
                     ERRID.WRN_TypeNotCLSCompliant1,
                     ERRID.WRN_OptionalValueNotCLSCompliant1,
                     ERRID.WRN_CLSAttrInvalidOnGetSet,
                     ERRID.WRN_TypeConflictButMerged6,
                     ERRID.WRN_ShadowingGenericParamWithParam1,
                     ERRID.WRN_CannotFindStandardLibrary1,
                     ERRID.WRN_EventDelegateTypeNotCLSCompliant2,
                     ERRID.WRN_DebuggerHiddenIgnoredOnProperties,
                     ERRID.WRN_SelectCaseInvalidRange,
                     ERRID.WRN_CLSEventMethodInNonCLSType3,
                     ERRID.WRN_ExpectedInitComponentCall2,
                     ERRID.WRN_NamespaceCaseMismatch3,
                     ERRID.WRN_UndefinedOrEmptyNamespaceOrClass1,
                     ERRID.WRN_UndefinedOrEmptyProjectNamespaceOrClass1,
                     ERRID.WRN_IndirectRefToLinkedAssembly2,
                     ERRID.WRN_DelaySignButNoKey,
                     ERRID.WRN_UnimplementedCommandLineSwitch,
                     ERRID.WRN_NoNonObsoleteConstructorOnBase3,
                     ERRID.WRN_NoNonObsoleteConstructorOnBase4,
                     ERRID.WRN_RequiredNonObsoleteNewCall3,
                     ERRID.WRN_RequiredNonObsoleteNewCall4,
                     ERRID.WRN_MissingAsClauseinOperator,
                     ERRID.WRN_ConstraintsFailedForInferredArgs2,
                     ERRID.WRN_ConditionalNotValidOnFunction,
                     ERRID.WRN_UseSwitchInsteadOfAttribute,
                     ERRID.WRN_TupleLiteralNameMismatch,
                     ERRID.WRN_ReferencedAssemblyDoesNotHaveStrongName,
                     ERRID.WRN_RecursiveAddHandlerCall,
                     ERRID.WRN_ImplicitConversionCopyBack,
                     ERRID.WRN_MustShadowOnMultipleInheritance2,
                     ERRID.WRN_RecursiveOperatorCall,
                     ERRID.WRN_ImplicitConversionSubst1,
                     ERRID.WRN_LateBindingResolution,
                     ERRID.WRN_ObjectMath1,
                     ERRID.WRN_ObjectMath2,
                     ERRID.WRN_ObjectAssumedVar1,
                     ERRID.WRN_ObjectAssumed1,
                     ERRID.WRN_ObjectAssumedProperty1,
                     ERRID.WRN_UnusedLocal,
                     ERRID.WRN_SharedMemberThroughInstance,
                     ERRID.WRN_RecursivePropertyCall,
                     ERRID.WRN_OverlappingCatch,
                     ERRID.WRN_DefAsgUseNullRefByRef,
                     ERRID.WRN_DuplicateCatch,
                     ERRID.WRN_ObjectMath1Not,
                     ERRID.WRN_BadChecksumValExtChecksum,
                     ERRID.WRN_MultipleDeclFileExtChecksum,
                     ERRID.WRN_BadGUIDFormatExtChecksum,
                     ERRID.WRN_ObjectMathSelectCase,
                     ERRID.WRN_EqualToLiteralNothing,
                     ERRID.WRN_NotEqualToLiteralNothing,
                     ERRID.WRN_UnusedLocalConst,
                     ERRID.WRN_ComClassInterfaceShadows5,
                     ERRID.WRN_ComClassPropertySetObject1,
                     ERRID.WRN_DefAsgUseNullRef,
                     ERRID.WRN_DefAsgNoRetValFuncRef1,
                     ERRID.WRN_DefAsgNoRetValOpRef1,
                     ERRID.WRN_DefAsgNoRetValPropRef1,
                     ERRID.WRN_DefAsgUseNullRefByRefStr,
                     ERRID.WRN_DefAsgUseNullRefStr,
                     ERRID.WRN_StaticLocalNoInference,
                     ERRID.WRN_InvalidAssemblyName,
                     ERRID.WRN_XMLDocBadXMLLine,
                     ERRID.WRN_XMLDocMoreThanOneCommentBlock,
                     ERRID.WRN_XMLDocNotFirstOnLine,
                     ERRID.WRN_XMLDocInsideMethod,
                     ERRID.WRN_XMLDocParseError1,
                     ERRID.WRN_XMLDocDuplicateXMLNode1,
                     ERRID.WRN_XMLDocIllegalTagOnElement2,
                     ERRID.WRN_XMLDocBadParamTag2,
                     ERRID.WRN_XMLDocParamTagWithoutName,
                     ERRID.WRN_XMLDocCrefAttributeNotFound1,
                     ERRID.WRN_XMLMissingFileOrPathAttribute1,
                     ERRID.WRN_XMLCannotWriteToXMLDocFile2,
                     ERRID.WRN_XMLDocWithoutLanguageElement,
                     ERRID.WRN_XMLDocReturnsOnWriteOnlyProperty,
                     ERRID.WRN_XMLDocOnAPartialType,
                     ERRID.WRN_XMLDocReturnsOnADeclareSub,
                     ERRID.WRN_XMLDocStartTagWithNoEndTag,
                     ERRID.WRN_XMLDocBadGenericParamTag2,
                     ERRID.WRN_XMLDocGenericParamTagWithoutName,
                     ERRID.WRN_XMLDocExceptionTagWithoutCRef,
                     ERRID.WRN_XMLDocInvalidXMLFragment,
                     ERRID.WRN_XMLDocBadFormedXML,
                     ERRID.WRN_InterfaceConversion2,
                     ERRID.WRN_LiftControlVariableLambda,
                     ERRID.WRN_LambdaPassedToRemoveHandler,
                     ERRID.WRN_LiftControlVariableQuery,
                     ERRID.WRN_RelDelegatePassedToRemoveHandler,
                     ERRID.WRN_AmbiguousCastConversion2,
                     ERRID.WRN_VarianceDeclarationAmbiguous3,
                     ERRID.WRN_ArrayInitNoTypeObjectAssumed,
                     ERRID.WRN_TypeInferenceAssumed3,
                     ERRID.WRN_VarianceConversionFailedOut6,
                     ERRID.WRN_VarianceConversionFailedIn6,
                     ERRID.WRN_VarianceIEnumerableSuggestion3,
                     ERRID.WRN_VarianceConversionFailedTryOut4,
                     ERRID.WRN_VarianceConversionFailedTryIn4,
                     ERRID.WRN_IfNoTypeObjectAssumed,
                     ERRID.WRN_IfTooManyTypesObjectAssumed,
                     ERRID.WRN_ArrayInitTooManyTypesObjectAssumed,
                     ERRID.WRN_LambdaNoTypeObjectAssumed,
                     ERRID.WRN_LambdaTooManyTypesObjectAssumed,
                     ERRID.WRN_MissingAsClauseinVarDecl,
                     ERRID.WRN_MissingAsClauseinFunction,
                     ERRID.WRN_MissingAsClauseinProperty,
                     ERRID.WRN_ObsoleteIdentityDirectCastForValueType,
                     ERRID.WRN_ImplicitConversion2,
                     ERRID.WRN_MutableStructureInUsing,
                     ERRID.WRN_MutableGenericStructureInUsing,
                     ERRID.WRN_DefAsgNoRetValFuncVal1,
                     ERRID.WRN_DefAsgNoRetValOpVal1,
                     ERRID.WRN_DefAsgNoRetValPropVal1,
                     ERRID.WRN_AsyncLacksAwaits,
                     ERRID.WRN_AsyncSubCouldBeFunction,
                     ERRID.WRN_UnobservedAwaitableExpression,
                     ERRID.WRN_UnobservedAwaitableDelegate,
                     ERRID.WRN_PrefixAndXmlnsLocalName,
                     ERRID.WRN_UseValueForXmlExpression3,
                     ERRID.WRN_ReturnTypeAttributeOnWriteOnlyProperty,
                     ERRID.WRN_InvalidVersionFormat,
                     ERRID.WRN_MainIgnored,
                     ERRID.WRN_EmptyPrefixAndXmlnsLocalName,
                     ERRID.WRN_DefAsgNoRetValWinRtEventVal1,
                     ERRID.WRN_AssemblyAttributeFromModuleIsOverridden,
                     ERRID.WRN_RefCultureMismatch,
                     ERRID.WRN_ConflictingMachineAssembly,
                     ERRID.WRN_PdbLocalNameTooLong,
                     ERRID.WRN_PdbUsingNameTooLong,
                     ERRID.WRN_XMLDocCrefToTypeParameter,
                     ERRID.WRN_AnalyzerCannotBeCreated,
                     ERRID.WRN_NoAnalyzerInAssembly,
                     ERRID.WRN_UnableToLoadAnalyzer,
                     ERRID.WRN_AttributeIgnoredWhenPublicSigning,
                     ERRID.WRN_Experimental
                    Return True
                Case Else
                    Return False
            End Select
        End Function

        Public Function IsFatal(code as ERRID) As Boolean
            Select Case code
                Case ERRID.FTL_InvalidInputFileName
                    Return True
                Case Else
                    Return False
            End Select
        End Function

        Public Function IsInfo(code as ERRID) As Boolean
            Select Case code
                Case ERRID.INF_UnableToLoadSomeTypesInAnalyzer
                    Return True
                Case Else
                    Return False
            End Select
        End Function

        Public Function IsHidden(code as ERRID) As Boolean
            Select Case code
                Case ERRID.HDN_UnusedImportClause,
                     ERRID.HDN_UnusedImportStatement
                    Return True
                Case Else
                    Return False
            End Select
        End Function
    End Module
End Namespace
