using AssociationAlgorithmExample.Services;
using AssociationAlgorithmExample.TestData;

Action<string> cout = x => Console.WriteLine(x);
//TODO add dependency injection
var getAssociationService = new GetAssociationsService();
var getDistinctAssociationService = new ProcessAssociationsService();
var deriveSupportService = new DeriveSupportService();
var deriveConfidenceService = new DeriveConfidenceService();
var displayAssociationService = new DisplayAssociationsService();
try
{
	

cout("Getting data");
var lineItems = GetTestData.GetLineItems();
cout("Processing associations");
var associations = getAssociationService.GetAssociations(lineItems);
cout("Processing distinct associations");
var distinctAssociations = getDistinctAssociationService.ProcessAssociations(associations);
cout("Calculating Confidences");
var distinctAssociationsWithConfidence = deriveConfidenceService.DeriveConfidence(distinctAssociations);
cout("Calculating Support");
var distinctAssociationsWithSupport = deriveSupportService.DeriveSupport(distinctAssociationsWithConfidence, lineItems.Count());
cout("Displaying Results");
displayAssociationService.DisplayAssociations(distinctAssociationsWithSupport);
}
catch (Exception ex)
{
	Console.WriteLine($"{ex.Message} - {ex.StackTrace}");
}