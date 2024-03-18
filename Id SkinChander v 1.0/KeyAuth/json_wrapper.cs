using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x0200000E RID: 14
	public class json_wrapper
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00004E40 File Offset: 0x00003040
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004E6C File Offset: 0x0000306C
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004EC8 File Offset: 0x000030C8
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000023C6 File Offset: 0x000005C6
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x0400003C RID: 60
		private DataContractJsonSerializer serializer;

		// Token: 0x0400003D RID: 61
		private object current_object;
	}
}
