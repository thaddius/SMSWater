Shader "Custom/Water" {
	Properties {
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Main texture", 2D) = "white" {}
		_WaterTex1 ("Water Texture 1", 2D) = "white" {}
		_WaterTex2 ("Water Texture 2", 2D) = "white" {}
		_Glossiness ("Smoothness", Range(0,1)) = 0.5
		_Metallic ("Metallic", Range(0,1)) = 0.0
	}
	SubShader {
		Tags { "Queue"="Transparent" "RenderType"="Tranparent" }
		LOD 200
		
		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows alpha vertex:vert

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

		sampler2D _MainTex;
		sampler2D _WaterTex1;
		sampler2D _WaterTex2;

		struct Input {
			float2 uv_MainTex;
			float2 uv_WaterTex1;
			float2 uv2_WaterTex2;
		};

		half _Glossiness;
		half _Metallic;
		fixed4 _Color;
		
		void vert (inout appdata_full v)
		{
			// Creates wave-like movement on a plane
            v.vertex.y += ( sin ( v.vertex.x * _Time.y * 0.5 ) * 0.05 );
            v.vertex.x += ( sin ( v.vertex.y * _Time.y * 0.5 ) * 0.05 );
         }

		void surf (Input IN, inout SurfaceOutputStandard o)
		{
			// Sample main tex (black teture)
			fixed4 c = tex2D (_MainTex, IN.uv_WaterTex1);
			
			// Sample both water textures
			fixed4 w1 = tex2D (_WaterTex1, IN.uv_WaterTex1);
			fixed4 w2 = tex2D (_WaterTex2, IN.uv2_WaterTex2);
			
			// Combine main texture with colour
			o.Albedo = _Color.rgb * c.rbg;
			// Metallic and smoothness come from slider variables
			o.Metallic = _Metallic;
			o.Smoothness = _Glossiness;
			// Apply water textures as alpha channel
			o.Alpha = (w1.a * w2.a) * 1.5;
		}
		ENDCG
	} 
	FallBack "Diffuse"
}
