<template>
    <div class="row" >
        <div class="col-sm-3">
              <div class="card-title"> </div>
                  
                
                  </div>

        </div>
        <div class="col-sm-6">
             <div class="card-title"> <label class="text-danger" role="alert">Hiện nay tình trạng lừa đảo xảy khá phổ biến, bạn nên cẩn trọng khi tiếp nhận thông tin</label></div>
            
            <div v-for="(item, index) in homeInit" :key="index" class="card">
                <div class="card-body">
                    <div class="card-title">
                        <h3 class="alert alert-info" role="alert">Tìm chính chủ của giấy tờ thất lạc</h3>
                    </div>
                    <div class="row">
                        <div class="col-sm-5">
                            <img src="@/assets/images/Canh.jpg" class="card-img-top" alt=""> 
                        </div>
                        <div class="col-sm-6">
                            <p><u>Thông tin về người nhặt được giấy tờ </u></p>
                            <p>Họ tên: {{item.hoTen}}</p>
                            <p>Số điện thoại liên hệ: {{item.soDienThoai}}</p>
                              <p>Ghi chú: {{item.ghiChu}}</p>
                            <p><u>Thông tin về giấy tờ đang tìm chính chủ </u></p>
                            <p>Loại Giấy tờ: {{item.tenLoai}}</p>
                            <p>Ngày nhặt được: {{item.ngayNhat}}</p>
                            <p>Nơi nhặt được: {{item.tenXa}}-{{item.tenHuyen}}-{{item.tenTinh}} </p>
                        </div>
                        <vue-goodshare-facebook
                                :page_url="urlShareFacebook"
                                title_social="Facebook"
                                has_counter
                                has_icon
                        ></vue-goodshare-facebook>
                        <vue-goodshare-twitter 
                        button_design="gradient"
                        :page_url="urlShareFacebook" 
                        has_icon
                        ></vue-goodshare-twitter>
                    </div>
                </div>
            </div>
        </div>
         <div class="col-sm-3">
            <a >
                <div class="card-title">
                      <h3 class="alert alert-info" role="alert">Khu vực cho thuê quảng cáo</h3>
                  </div>
                    <a href="http://viethanit.edu.vn" target="_self"> 
            <img src="@/assets/images/banner-hoc-bong.png"  class="card-img-top"  title="Viet Han IT - Một điểm tựa" alt="qc">   
                        <div class="card-title"> </div>
                        <img src="@/assets/images/vh2019.png" class="card-img-top" alt="qc"> </a>
                        <div class="card-title"> </div>  
                          <a href="https://thegioididong.com" target="_self">   
                        <img src="@/assets/images/vm1.jpg" class="card-img-top" alt="qc">
                         <div class="card-title"> </div>    
                        <img src="@/assets/images/vm2.jpg" class="card-img-top" alt="qc">
                          </a>
                    
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
        </div>
      </div>
</template>

<script>
import axios from 'axios';
import VueGoodshareFacebook from 'vue-goodshare/src/providers/Facebook';
import VueGoodshareTwitter from 'vue-goodshare/src/providers/Twitter.vue';
export default {
    name: 'home',
    components: {
        VueGoodshareFacebook,
        VueGoodshareTwitter
    },
    data() {
        return {
            urlShareFacebook: null,
            homeInit:{
                ghiChu: null,
                hoTen: null,
                ngayNhat: null,
                soDienThoai:null,
                tenHuyen: null,
                tenLoai: null,
                tenTinh: null,
                tenXa:null,
            }
        }
    },
    mounted() {
        var _this = this;
        axios.get("http://localhost:5004/home").then(response => {
            debugger;
            _this.homeInit = response.data;
        }).catch(error => console.log(error));
        
        _this.urlShareFacebook = window.location.href;
    },
    updated:{
                
    }

}
</script>
