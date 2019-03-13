<template>
    <div class="row">
        <div class="col-sm-3">
            <a href="#">
                <img src="@/assets/images/roi-giay-to1.jpg" class="card-img-top" alt="banner">
                <img src="@/assets/images/quality-comparison-blog.jpg" class="card-img-top" alt="banner">
            </a>
        </div>
        <div class="col-sm-6">
                <h4 class="text-info">Thông tin về bạn</h4>
                <div class="form-group row">
                    <label class="col-sm-4 col-form-label">Họ tên</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" placeholder="họ tên của bạn là gì??...">
                    </div>
                </div>

                <div class="form-group row">



                <label for="exampleFormControlSelect1" class="col-sm-4 col-form-label"> Giới tính</label>
                <div class="col-sm-8">
                    <select class="form-control" id="exampleFormControlSelect1">
                        <option>Nam</option>
                        <option>Nữ</option>
                        
                    </select>
                </div>
            </div>



                <div class="form-group row">
                    <label class="col-sm-4 col-form-label">Quê Quán</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" placeholder="hãy cho chúng tôi chút thông tin về nơi bạn đang ở...">
                    </div>
                </div>
                <div class="form-group row">
                        <label class="col-sm-4 col-form-label">Số điện thoại liên hệ</label>
                        <div class="col-sm-8">
                            <input type="text" class="form-control" placeholder="Đây là thông tin giúp người thất lạc giấy tờ tìm thấy bạn">
                        </div>
                    </div>
                <h4 class="text-info">Thông tin về giấy tờ nhặt được </h4>
                <div class="form-group row">
                        
                                <label for="exampleFormControlSelect1" class="col-sm-4 col-form-label">Loại giấy tờ</label>
                                <div class="col-sm-8">
                                    <select class="form-control" id="exampleFormControlSelect1">
                                        <option>HÃY CHỌN LOẠI GIẤY TỜ MÀ BẠN NHẶT ĐƯỢC</option>
                                        <option>Bảo hiểm y tế</option>
                                        <option>Giấy phép lái xe</option>
                                        <option>Chứng minh nhân dân</option>
                                        <option>Thẻ ngân hàng</option>
                                        <option>Tôi nhặt được loại giấy tờ khác   </option>
                                    </select>
                                </div>
                            </div>
                                <div class="form-group row">       
                    <label class="col-sm-4 col-form-label">Ngày nhặt được</label>
                    <div class="col-sm-8">
                        <input type="date" class="form-control" placeholder="Ngày...">
                    </div>
                </div>
                <div class="form-group row">

                        <label for="exampleFormControlSelect1" class="col-sm-4 col-form-label"> Nơi bạn nhặt được giấy tờ</label>
                        <div class="col-sm-8">
                            <select name="exampleFormControlSelect" class="form-control" id="exampleFormControlSelect1">
                            <option>Tỉnh/thành phố</option>
                            </select>
                            <select name="exampleFormControlSelect2" class="form-control" id="exampleFormControlSelect2">
                            <option>huyện/thị trấn</option>
                            </select>
                            <select name="exampleFormControlSelect3" class="form-control" id="exampleFormControlSelect3">
                            <option>phường/xã</option>
                            </select>
                        </div>
                            </div>

                <!-- <div class="form-group row">
                    <label class="col-sm-4 col-form-label">Sđt liên hệ</label>
                    <div class="col-sm-8">
                        <input type="text" class="form-control" placeholder="Sđt...">
                    </div>
                </div> -->
                <div class="form-group row">
                    <label for="exampleFormControlTextarea1" class="col-sm-2 col-form-label">Ghi chú</label>
                    <div class="col-sm-10">
                        <textarea class="form-control" rows="3"></textarea>
                    </div>
                </div>
                <div class="form-group">
                    <label class="text-danger">Vui lòng up ảnh giấy tờ đánh rơi</label>
                    <label class="text-danger">**LƯU Ý: vì đảm bảo sự an toàn cho thông tin cá nhân của chính chủ yêu cầu cần che đi những thông tin như:Số CMND, số thẻ ngân hàng và một số thông tin nhạy cảm khác,...nếu bạn không thực hiện điều này thì chúng tôi sẽ tiến hành sửa đổi ảnh mà bạn đã upload lên hệ thống để đảm an toàn- trật tự xã hội..XIN CẢM ƠN </label>
                    <input type="file" class="form-control-file">
                    
                </div>
                <button type="button" class="btn btn-primary btn-lg" name="button"> Đăng bài</button>

            </div>
            <div class="form-group">
        </div>
        <div class="col-sm-3">

            <a >
                <div class="card-title">
                      <h3 class="alert alert-info" role="alert">Khu vực cho thuê quảng cáo</h3>
                  </div>
           <img src="@/assets/images/banner-hoc-bong.png" class="card-img-top" alt="qc">   
            <div class="card-title"> </div>
            <img src="@/assets/images/rater-featured-image.jpg" class="card-img-top" alt="qc">
             <div class="card-title"> </div>
            <img src="@/assets/images/240_F_117782591_AdAQ13K6xrDkhokujeIJxKTg0Ki4DafD.jpg" class="card-img-top" alt="qc">
           
           <div class="card-title">
                      
                  </div>
            <div class="card-title">
                      <h5 class="alert alert-info" role="alert">LIÊN HỆ QUẢNG CÁO</h5>
                       <h6 class="alert alert-info" role="alert"> Holine:  0357485599</h6>
                        <h6 class="alert alert-info" role="alert"> Gmail:  LVTLIN98@GMAIL.COM</h6>
                  </div>
                  
            </a>
           
        </div>
        
    </div>
</template>
<script>
export default {
    name: 'FindDocument'
}
</script>

