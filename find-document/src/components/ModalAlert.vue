<template>
    <b-modal
      v-model="show"
      title="Error"
    >
      <b-container fluid>
        <b-row class="mb-1 text-center">
          <b-col cols="12">
              {{dataShow}}
          </b-col>
        </b-row>
      </b-container>
      <div slot="modal-footer" class="w-100">
        <b-button
          variant="primary"
          size="sm"
          class="float-center"
          @click="show=false"
        >
          Close
        </b-button>
      </div>
    </b-modal>
</template>

<script>
  export default {
      name: "ModalAlert",
      props:{
          dataShow:{
              type: String,
          }
      },
    data() {
      return {
        show: true,
      }
    },
    watch:{
        show(oldVal){
            if(oldVal == false){
                this.$emit("closedModal");
            }
        }
    }
  }
</script>