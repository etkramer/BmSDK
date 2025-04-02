#pragma once

struct FieldInfo
{
public:
	FieldInfo(class UField* field);

	string managedName;
	string managedPathName;

private:
	class UField* field;
	string GetNameManaged();
	string GetPathNameManaged();
};
