// See https://aka.ms/new-console-template for more information
global using System;
using Dapr.Client;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.Net.Http.Json;
using Grpc.Net.Client;
using System.Threading;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
Console.WriteLine("Hello, World!");

// Pubsub
string PUBSUB_NAME = "order_pub_sub";
string TOPIC_NAME = "orders";
Random random = new Random();

while (true)
{
    try
    {
        System.Threading.Thread.Sleep(5000);
        int orderId = random.Next(1, 1000);
        CancellationTokenSource source = new CancellationTokenSource();
        CancellationToken cancellationToken = source.Token;
        using var client = new DaprClientBuilder().Build();
        //Using Dapr SDK to publish a topic
        await client.PublishEventAsync(PUBSUB_NAME, TOPIC_NAME, orderId, cancellationToken);
        Console.WriteLine("Published data: " + orderId);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
}
