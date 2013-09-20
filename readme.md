##A simple api for published Umbraco 6+ content. Made for Ajax queries.

Api starts at 

	/umbraco/publishedcontent

All requests must be as GET and as application/json (so you'll need fiddler/curl/restconsole to try it)

###Returns a single node:

	/node/getnode/{id} : gets node by id
	/node/getnode?path=.. : gets node by path

	/node/getparent/{id} : gets parent of 1065
	/node/getparent?path=...

###Returns array of nodes:

	/nodes/getchildren/{id} : gets all child nodes of the node with that id 
	/nodes/getchildren?path=...

	/nodes/getancestors/{id}
	/nodes/getancestors?path=...


###Returns hierarchy of nodes:

	/nodetree/getdescendants/{id}
	/nodetree/getdescendants?path=...


###Node format for single node

	{
		"Id": 1087,
		"Level": 3,
		"NiceUrl": "/foo/bar/",
		"Name": "Bar",
		"UrlName": "bar",
		"NodeTypeAlias": "content",
		"CreatorName": "admin",
		"template": 1093,
		"Properties": {
			"umbracoNaviHide": "0",
			"contactPerson": "",
			"pageAdministrator": "",
			"linkedNodes": "",
			"bodyText": "<p>yada yada yada</p>",
			"header": "",
			"introduction": ""
		},
		"CreateDate": "2013-09-20T06:27:16",
		"UpdateDate": "2013-09-20T06:35:25",
		"SortOrder": 3,
		"ParentId": 1086,
		"ChildIds": []
	}