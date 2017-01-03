package com.pluralsight.orderfulfillment.config;

import org.apache.camel.builder.RouteBuilder;
import org.springframework.context.annotation.Configuration;

import com.pluralsight.orderfulfillment.order.OrderStatus;

@Configuration
public class IntegrationConfig extends RouteBuilder {
	@Override
	public void configure() throws Exception {
		from(
				"sql:"  
				+ "SELECT id FROM orders.order WHERE status = '" 
			    + OrderStatus.NEW.getCode() 
			    + "'" 
			    + "?" 
			    + "consumer.onConsume=UPDATE orders.order SET status='" 
			    + OrderStatus.PROCESSING.getCode() 
			    + "' WHERE id = :#id" 
			    + "&" 
			    + "dataSource=dataSource"
			).
			to(
				"log:" +
				"com.pluralsight.orderfulfillment" +
				"?" +		
				"level=INFO"
			);
	}
}
