Shader "PACKT/MOON" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
	}

	SubShader {
		CGPROGRAM
		#pragma surface surf Lambert

		struct Input{
			float2 uv_MainTex;
		};

		sampler2D _MainTex;
		float4 _Color;

		void surf (Input In, inout SurfaceOutput o){
			o.Albedo = tex2D (_MainTex, In.uv_MainTex).rgb * _Color.rgb;
		}
		ENDCG	 
	}
}
