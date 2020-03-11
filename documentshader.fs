#version 330 core
out vec4 FragColor;

uniform bool isindex;

void main()
{
	if(isindex)
	FragColor=vec4(0.7f,0.4f,0.4f,1.0f);
	else FragColor=vec4(0.5f,0.5f,0.5f,1.0f);
}

