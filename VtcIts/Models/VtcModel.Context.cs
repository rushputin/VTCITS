﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VtcIts.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class VtcContext : DbContext
    {
        public VtcContext()
            : base("name=VtcContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Building> Buildings { get; set; }
        public DbSet<ExternalLocation> ExternalLocations { get; set; }
        public DbSet<KemtahTech> KemtahTeches { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingParticipant> MeetingParticipants { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Setting> Settings { get; set; }
    
        public virtual ObjectResult<AvailableBuildings_Result> AvailableBuildings(Nullable<int> meetingId)
        {
            var meetingIdParameter = meetingId.HasValue ?
                new ObjectParameter("MeetingId", meetingId) :
                new ObjectParameter("MeetingId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AvailableBuildings_Result>("AvailableBuildings", meetingIdParameter);
        }
    
        public virtual ObjectResult<AvailablePeople_Result> AvailablePeople(Nullable<int> meetingId)
        {
            var meetingIdParameter = meetingId.HasValue ?
                new ObjectParameter("MeetingId", meetingId) :
                new ObjectParameter("MeetingId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AvailablePeople_Result>("AvailablePeople", meetingIdParameter);
        }
    
        public virtual ObjectResult<AvailableRooms_Result> AvailableRooms(Nullable<int> meetingId, Nullable<int> buildingId)
        {
            var meetingIdParameter = meetingId.HasValue ?
                new ObjectParameter("MeetingId", meetingId) :
                new ObjectParameter("MeetingId", typeof(int));
    
            var buildingIdParameter = buildingId.HasValue ?
                new ObjectParameter("BuildingId", buildingId) :
                new ObjectParameter("BuildingId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AvailableRooms_Result>("AvailableRooms", meetingIdParameter, buildingIdParameter);
        }
    
        public virtual ObjectResult<AvailableExLocations_Result> AvailableExLocations(Nullable<int> meetingId)
        {
            var meetingIdParameter = meetingId.HasValue ?
                new ObjectParameter("MeetingId", meetingId) :
                new ObjectParameter("MeetingId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AvailableExLocations_Result>("AvailableExLocations", meetingIdParameter);
        }
    
        public virtual ObjectResult<AvailableBadgeNumbers_Result> AvailableBadgeNumbers(Nullable<int> meetingId, string searchTerm, Nullable<int> maxResults)
        {
            var meetingIdParameter = meetingId.HasValue ?
                new ObjectParameter("MeetingId", meetingId) :
                new ObjectParameter("MeetingId", typeof(int));
    
            var searchTermParameter = searchTerm != null ?
                new ObjectParameter("SearchTerm", searchTerm) :
                new ObjectParameter("SearchTerm", typeof(string));
    
            var maxResultsParameter = maxResults.HasValue ?
                new ObjectParameter("MaxResults", maxResults) :
                new ObjectParameter("MaxResults", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AvailableBadgeNumbers_Result>("AvailableBadgeNumbers", meetingIdParameter, searchTermParameter, maxResultsParameter);
        }
    
        public virtual ObjectResult<AvailableEmails_Result> AvailableEmails(Nullable<int> meetingId, string searchTerm, Nullable<int> maxResults)
        {
            var meetingIdParameter = meetingId.HasValue ?
                new ObjectParameter("MeetingId", meetingId) :
                new ObjectParameter("MeetingId", typeof(int));
    
            var searchTermParameter = searchTerm != null ?
                new ObjectParameter("SearchTerm", searchTerm) :
                new ObjectParameter("SearchTerm", typeof(string));
    
            var maxResultsParameter = maxResults.HasValue ?
                new ObjectParameter("MaxResults", maxResults) :
                new ObjectParameter("MaxResults", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AvailableEmails_Result>("AvailableEmails", meetingIdParameter, searchTermParameter, maxResultsParameter);
        }
    
        public virtual ObjectResult<GetDetailedReport_Result> GetDetailedReport()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDetailedReport_Result>("GetDetailedReport");
        }
    
        public virtual ObjectResult<GetSummaryReport_Result> GetSummaryReport()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSummaryReport_Result>("GetSummaryReport");
        }
    
        public virtual ObjectResult<GetSettings_Result> GetSettings()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSettings_Result>("GetSettings");
        }
    }
}