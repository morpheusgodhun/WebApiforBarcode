namespace MainAppLayer.ApplicationAbstracts;
public abstract class ResponseBase {

    #region Constructors
    public ResponseBase() {
        Code = 200;
        Status = "success";
        Success = true;
    }
    #endregion

    #region Properties
    public int Code {
        get; set;
    }

    public string Status {
        get; set;
    }

    public bool Success {
        get; set;
    }

    public string Message {
        get; set;
    }

    #endregion

    #region Methods
    public void OnSucess(string message = null, int code = 200,
        string status = "success", bool success = true) {
        Code = code;
        Status = status;
        Success = success;
        Message = message;
    }

    public void OnError(string message, int code = 400,
        string status = "error", bool success = false) {
        Code = code;
        Status = status;
        Success = success;
        Message = message;
    }
    #endregion

}
public abstract class BaseResponse<T>
    : ResponseBase { }

public abstract class DataResponse
    : ResponseBase { }


public abstract class PagedResponseBase
    : ResponseBase {

    #region Properties
    public int PageSize {
        get; set;
    }

    public int PageNumber {
        get; set;
    }

    public int PageCount {
        get; set;
    }

    public bool HasPreviousPage {
        get {
            return PageNumber > 1;
        }
    }

    public bool HasNextPage {
        get {
            return PageNumber < PageCount;
        }
    }
    #endregion

}
public class CurrentResponse
    : ResponseBase { }