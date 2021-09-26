#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


template <typename R>
struct VirtFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.String
struct String_t;
// System.Data.XmlToDatasetMap/XmlNodeIdentety
struct XmlNodeIdentety_tDB2D0FFBEC368B86282BBEC679577C3E70B70454;

IL2CPP_EXTERN_C RuntimeClass* XmlNodeIdentety_tDB2D0FFBEC368B86282BBEC679577C3E70B70454_il2cpp_TypeInfo_var;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object

struct Il2CppArrayBounds;

// System.Array


// System.String
struct String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::m_stringLength
	int32_t ___m_stringLength_0;
	// System.Char System.String::m_firstChar
	Il2CppChar ___m_firstChar_1;

public:
	inline static int32_t get_offset_of_m_stringLength_0() { return static_cast<int32_t>(offsetof(String_t, ___m_stringLength_0)); }
	inline int32_t get_m_stringLength_0() const { return ___m_stringLength_0; }
	inline int32_t* get_address_of_m_stringLength_0() { return &___m_stringLength_0; }
	inline void set_m_stringLength_0(int32_t value)
	{
		___m_stringLength_0 = value;
	}

	inline static int32_t get_offset_of_m_firstChar_1() { return static_cast<int32_t>(offsetof(String_t, ___m_firstChar_1)); }
	inline Il2CppChar get_m_firstChar_1() const { return ___m_firstChar_1; }
	inline Il2CppChar* get_address_of_m_firstChar_1() { return &___m_firstChar_1; }
	inline void set_m_firstChar_1(Il2CppChar value)
	{
		___m_firstChar_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_5;

public:
	inline static int32_t get_offset_of_Empty_5() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_5)); }
	inline String_t* get_Empty_5() const { return ___Empty_5; }
	inline String_t** get_address_of_Empty_5() { return &___Empty_5; }
	inline void set_Empty_5(String_t* value)
	{
		___Empty_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Empty_5), (void*)value);
	}
};


// System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_com
{
};

// System.Data.XmlToDatasetMap/XmlNodeIdentety
struct XmlNodeIdentety_tDB2D0FFBEC368B86282BBEC679577C3E70B70454  : public RuntimeObject
{
public:
	// System.String System.Data.XmlToDatasetMap/XmlNodeIdentety::LocalName
	String_t* ___LocalName_0;
	// System.String System.Data.XmlToDatasetMap/XmlNodeIdentety::NamespaceURI
	String_t* ___NamespaceURI_1;

public:
	inline static int32_t get_offset_of_LocalName_0() { return static_cast<int32_t>(offsetof(XmlNodeIdentety_tDB2D0FFBEC368B86282BBEC679577C3E70B70454, ___LocalName_0)); }
	inline String_t* get_LocalName_0() const { return ___LocalName_0; }
	inline String_t** get_address_of_LocalName_0() { return &___LocalName_0; }
	inline void set_LocalName_0(String_t* value)
	{
		___LocalName_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___LocalName_0), (void*)value);
	}

	inline static int32_t get_offset_of_NamespaceURI_1() { return static_cast<int32_t>(offsetof(XmlNodeIdentety_tDB2D0FFBEC368B86282BBEC679577C3E70B70454, ___NamespaceURI_1)); }
	inline String_t* get_NamespaceURI_1() const { return ___NamespaceURI_1; }
	inline String_t** get_address_of_NamespaceURI_1() { return &___NamespaceURI_1; }
	inline void set_NamespaceURI_1(String_t* value)
	{
		___NamespaceURI_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___NamespaceURI_1), (void*)value);
	}
};


// System.Boolean
struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37, ___m_value_0)); }
	inline bool get_m_value_0() const { return ___m_value_0; }
	inline bool* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(bool value)
	{
		___m_value_0 = value;
	}
};

struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields
{
public:
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;

public:
	inline static int32_t get_offset_of_TrueString_5() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___TrueString_5)); }
	inline String_t* get_TrueString_5() const { return ___TrueString_5; }
	inline String_t** get_address_of_TrueString_5() { return &___TrueString_5; }
	inline void set_TrueString_5(String_t* value)
	{
		___TrueString_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TrueString_5), (void*)value);
	}

	inline static int32_t get_offset_of_FalseString_6() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___FalseString_6)); }
	inline String_t* get_FalseString_6() const { return ___FalseString_6; }
	inline String_t** get_address_of_FalseString_6() { return &___FalseString_6; }
	inline void set_FalseString_6(String_t* value)
	{
		___FalseString_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FalseString_6), (void*)value);
	}
};


// System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA  : public ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52
{
public:

public:
};

struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields
{
public:
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___enumSeperatorCharArray_0;

public:
	inline static int32_t get_offset_of_enumSeperatorCharArray_0() { return static_cast<int32_t>(offsetof(Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields, ___enumSeperatorCharArray_0)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_enumSeperatorCharArray_0() const { return ___enumSeperatorCharArray_0; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_enumSeperatorCharArray_0() { return &___enumSeperatorCharArray_0; }
	inline void set_enumSeperatorCharArray_0(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___enumSeperatorCharArray_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumSeperatorCharArray_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_com
{
};

// System.Int32
struct Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046 
{
public:
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046, ___m_value_0)); }
	inline int32_t get_m_value_0() const { return ___m_value_0; }
	inline int32_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int32_t value)
	{
		___m_value_0 = value;
	}
};


// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5__padding[1];
	};

public:
};


// System.StringComparison
struct StringComparison_tCC9F72B9B1E2C3C6D2566DD0D3A61E1621048998 
{
public:
	// System.Int32 System.StringComparison::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(StringComparison_tCC9F72B9B1E2C3C6D2566DD0D3A61E1621048998, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif



// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Boolean System.String::Equals(System.String,System.String,System.StringComparison)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_Equals_mD65682B0BB7933CC7A8561AE34DED02E4F3BBBE5 (String_t* ___a0, String_t* ___b1, int32_t ___comparisonType2, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.Data.XmlToDatasetMap/XmlNodeIdentety::.ctor(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void XmlNodeIdentety__ctor_mF95AB35C3B3509393CC0DF933B4961AB15C73491 (XmlNodeIdentety_tDB2D0FFBEC368B86282BBEC679577C3E70B70454 * __this, String_t* ___localName0, String_t* ___namespaceURI1, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		String_t* L_0 = ___localName0;
		__this->set_LocalName_0(L_0);
		String_t* L_1 = ___namespaceURI1;
		__this->set_NamespaceURI_1(L_1);
		return;
	}
}
// System.Int32 System.Data.XmlToDatasetMap/XmlNodeIdentety::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t XmlNodeIdentety_GetHashCode_mE117B700DC03A4109832691B8FFD221A464BC2AA (XmlNodeIdentety_tDB2D0FFBEC368B86282BBEC679577C3E70B70454 * __this, const RuntimeMethod* method)
{
	{
		String_t* L_0 = __this->get_LocalName_0();
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 System.Object::GetHashCode() */, L_0);
		return L_1;
	}
}
// System.Boolean System.Data.XmlToDatasetMap/XmlNodeIdentety::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool XmlNodeIdentety_Equals_m3146CB0D203AA00EBC930295E476831CF827BFA4 (XmlNodeIdentety_tDB2D0FFBEC368B86282BBEC679577C3E70B70454 * __this, RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&XmlNodeIdentety_tDB2D0FFBEC368B86282BBEC679577C3E70B70454_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	XmlNodeIdentety_tDB2D0FFBEC368B86282BBEC679577C3E70B70454 * V_0 = NULL;
	{
		RuntimeObject * L_0 = ___obj0;
		V_0 = ((XmlNodeIdentety_tDB2D0FFBEC368B86282BBEC679577C3E70B70454 *)CastclassSealed((RuntimeObject*)L_0, XmlNodeIdentety_tDB2D0FFBEC368B86282BBEC679577C3E70B70454_il2cpp_TypeInfo_var));
		String_t* L_1 = __this->get_LocalName_0();
		XmlNodeIdentety_tDB2D0FFBEC368B86282BBEC679577C3E70B70454 * L_2 = V_0;
		NullCheck(L_2);
		String_t* L_3 = L_2->get_LocalName_0();
		bool L_4;
		L_4 = String_Equals_mD65682B0BB7933CC7A8561AE34DED02E4F3BBBE5(L_1, L_3, 5, /*hidden argument*/NULL);
		if (!L_4)
		{
			goto IL_002e;
		}
	}
	{
		String_t* L_5 = __this->get_NamespaceURI_1();
		XmlNodeIdentety_tDB2D0FFBEC368B86282BBEC679577C3E70B70454 * L_6 = V_0;
		NullCheck(L_6);
		String_t* L_7 = L_6->get_NamespaceURI_1();
		bool L_8;
		L_8 = String_Equals_mD65682B0BB7933CC7A8561AE34DED02E4F3BBBE5(L_5, L_7, 5, /*hidden argument*/NULL);
		return L_8;
	}

IL_002e:
	{
		return (bool)0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
