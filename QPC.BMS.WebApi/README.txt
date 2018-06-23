Cấu hình Rest trong file webconfig dựa theo đoạn code này.
- address ="rest" : đường dẫ sẽ thêm từ này vào
- helpEnabled="true" : cho phép bật help cho api
=> qua 2 cấu hình trên đường dẫn help sẽ là: domain/MainServices.svc/rest/help
---------------------------------------------------------------------------------------------

<system.serviceModel>
    <behaviors>
      <serviceBehaviors>
        <behavior name="">
          <serviceMetadata httpGetEnabled="true" httpsGetEnabled="true" />
          <serviceDebug includeExceptionDetailInFaults="false" />
        </behavior>
      </serviceBehaviors>
    <endpointBehaviors>
      <behavior name="restBehavior">
        <webHttp helpEnabled="true"/>
      </behavior>
    </endpointBehaviors>
    </behaviors>
    <serviceHostingEnvironment aspNetCompatibilityEnabled="true"
        multipleSiteBindingsEnabled="true" />
    <services>
      <service name="Tungnt.NET.WCFRestDemo.WCFRestDemo">
        <endpoint name ="RESTEndPoint" contract ="Tungnt.NET.WCFRestDemo.IWCFRestDemo" binding ="webHttpBinding" address ="rest" behaviorConfiguration ="restBehavior"/>
      </service>
    </services>
  </system.serviceModel>